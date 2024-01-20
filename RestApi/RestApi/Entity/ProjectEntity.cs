using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Web.UI;

namespace RestApi.Entity.ProjectEntity
{
    public class ProjectEntity
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int ItemsCount { get; set; }

        public int Icon { get; set; }
        public int ItemType { get; set; }
        public Object [] Children { get; set;}
       

        public string GetObjectAsJson()
        {
            return new JavaScriptSerializer().Serialize(this);
        }


    }
}
