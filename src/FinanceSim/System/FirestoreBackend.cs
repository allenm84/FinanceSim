using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using Newtonsoft.Json;

namespace FinanceSim
{
  public static class FirestoreBackend
  {
    private const string ProjectId = "mapa-apps";
    private const string CollectionName = "financeSim";

    private static readonly JsonSerializerSettings Settings = new()
    {
      TypeNameHandling = TypeNameHandling.Auto,
    };

    private static Profile ParseProfile(DocumentSnapshot document)
    {
      var values = document.ToDictionary();
      var encryptedJson = values["Data"] as string;
      var decryptedJson = StringCipher.Decrypt(encryptedJson);
      return JsonConvert.DeserializeObject<Profile>(decryptedJson, Settings);
    }

    public static async Task<IEnumerable<Profile>> FetchAsync()
    {
      var db = await FirestoreDb.CreateAsync(ProjectId);
      var collectionRef = db.Collection(CollectionName);
      var snapshot = await collectionRef.GetSnapshotAsync();
      return snapshot.Documents.Select(ParseProfile).OrderBy(it => it.Created);
    }

    public static async Task PushAsync(IEnumerable<Profile> profiles, IEnumerable<string> removedProfileIds)
    {
      var db = await FirestoreDb.CreateAsync(ProjectId);
      var collectionRef = db.Collection(CollectionName);

      foreach (var profile in profiles)
      {
        var decryptedJson = JsonConvert.SerializeObject(profile, Settings);
        var encryptedJson = StringCipher.Encrypt(decryptedJson);
        var docRef = collectionRef.Document(profile.Id);
        var docData = new Dictionary<string, object>
        {
          { "Name", profile.Name },
          { "Created", profile.Created.ToUniversalTime() },
          { "Data", encryptedJson },
        };
        await docRef.SetAsync(docData);
      }

      foreach (var id in removedProfileIds)
      {
        await collectionRef.Document(id).DeleteAsync();
      }
    }
  }
}
