using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Quyền hạn.
    /// </summary>
    [Table("SPermission")]
    public class Permission : Entity<string>
    {
        private readonly List<Permission> _children;

        [Key]
        [MaxLength(255)]
        public override string Id { get; set; }

        [MaxLength(512)]
        [Required]
        public virtual string Name { get; set; }

        [MaxLength(255)]
        public virtual string Description { get; set; }

        [MaxLength(255)]
        public virtual string ParentId { get; set; }

        public virtual int SortOrder { get; set; }

        public Permission(string id, string name, string description) 
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.ParentId = null;
            this.SortOrder = 1;
            _children = new List<Permission>();
        }

        public Permission CreateChildPermission(string id, string name)
        {
            return CreateChildPermission(id, name, null);
        }

        public Permission CreateChildPermission(string id, string name, string description)
        {
            if (name == null)
            {
                throw new ArgumentNullException("id");
            }

            var permission = new Permission(id, name, description);
            permission.ParentId = Id;
            if (_children.Any())
            {
                permission.SortOrder = _children.Max(x => x.SortOrder) + 1;
            }    
            _children.Add(permission);
            return permission;
        }

        public void RemoveChildPermission(string id)
        {
            _children.RemoveAll((Permission p) => p.Id == id);
        }
    }
}
