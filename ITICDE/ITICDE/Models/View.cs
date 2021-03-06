using ITICDE.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITICDE.Models
{
    public class View
    {
		public View()
		{
            Files = new List<File>();
            Users = new List<User>();
            Tasks = new List<Task>();
		}
        #region Properties
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(32)")]
        public ViewType Type { get; set; } = ViewType.View3D;

        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; } = DateTime.Now;



        #endregion

        #region NavigationProperties
        [Required]
        public string UserId { get; set; }
        public User CreatorUser { get; set; }
        public List<User> Users { get; set; }

        [Required]
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public List <File> Files { get; set; }
        public List<Task> Tasks { get; set; }

        #endregion
    }
}
