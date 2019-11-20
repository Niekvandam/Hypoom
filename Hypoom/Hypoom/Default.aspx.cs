using Hypoom.Objects;
using System;
using System.Diagnostics;
using System.Web.UI;

namespace Hypoom
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void test_Click(object sender, EventArgs e)
        {
            var factory = new StreamingService().ExecuteCreation(Services.Spotify, testtextbox.Text);
            var song = factory.GetSong();
            Debug.WriteLine(song);
        }
    }
}