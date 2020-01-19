using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoClub
{
    public class Video
    {
// ====== private properties =========
        private int videoID;
        private string videoName;
        private string yearOfRelease;
        private int ageRating;
        private int quantity;
        private string genre;
        private byte[] imageData;

        // ======= Constructor ==========

        public Video() { }

        // ===== public properties ======
       
        public byte[] ImageData { get; set; }
        public string Videoname { get; set; }
        public string Yearofrelease { get; set; }
        public int Agerating { get; set; }
        public int Quantity { get; set; }
        public string Genre { get; set; }


    }
}
