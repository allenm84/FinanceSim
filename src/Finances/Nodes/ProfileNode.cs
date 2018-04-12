using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finances
{
  public class ProfileNode : TreeNode
  {
    public ProfileNode(Profile profile) : base(profile.Name)
    {
      Profile = profile;
    }

    public Profile Profile { get; }
  }
}
