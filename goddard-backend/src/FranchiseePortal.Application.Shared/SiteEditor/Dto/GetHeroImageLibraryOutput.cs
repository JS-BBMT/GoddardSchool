using System;
using System.Collections.Generic;
using System.Text;

namespace FranchiseePortal.SiteEditor.Dto
{
    public class GetHeroImageLibraryOutput
    {
        public List<HeroImage> HeroImageLibrary { get; set; }
        public int SelectedImageId { get; set; }

        public GetHeroImageLibraryOutput(List<HeroImage> heroImageLibrary, int selectedImageId)
        {
            HeroImageLibrary = heroImageLibrary;
            SelectedImageId = selectedImageId;
        }

        public GetHeroImageLibraryOutput()
        {
            HeroImageLibrary = new List<HeroImage>();
            SelectedImageId = 0;
        }
    }
}