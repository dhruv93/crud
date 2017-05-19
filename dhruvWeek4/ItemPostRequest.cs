using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhruvWeek4
{
    public class ItemPostRequest
    {
        public int random
        {
            get;
            set;
        }
        public string charactertype
        {
            get;
            set;
        }
        public int characterlevel
        {
            get;
            set;
        }
        public ItemPostRequest() { }
        public ItemPostRequest(int random, string charactertype, int characterlevel)
        {
            this.random = random;
            this.characterlevel = characterlevel;
            this.charactertype = charactertype;

        }
    }
}
