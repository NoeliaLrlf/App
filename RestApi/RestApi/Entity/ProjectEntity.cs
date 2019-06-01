using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApi.Entity.ProjectEntity
{
    public class ProjectEntity
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int ItemsCount { get; set; }

        public int Icon { get; set; }
        public int ItemType { get; set; }

        public int? ParentId { get; set; }
        public bool Collapsed { get; set; }
        public int ItemOrder { get; set; }
        public Object [] Children { get; set; }
        public bool IsProjectShared { get; set; }
        public int? ProjectShareOwnerName { get; set; }
        public int? ProjectShareOwnerEmail { get; set; }
        public bool IsShareApproved { get; set; }
        public bool IsOwnProject { get; set; }
        public string LastSyncedDateTime { get; set; }
        public string LastUpdatedDate { get; set; }
        public bool Deleted { get; set; }
        public int? SyncClientCreationId { get; set; }


    }
}
