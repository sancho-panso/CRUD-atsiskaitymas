﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Crud.App.Domains
{
    public class ItemsGroup
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ItemsGroupID { get; set; }
        [Required]
        [MaxLength(50)]
        public string ItemsGroupCode { get; set; }
        [Required]
        [MaxLength(50)]
        public string ItemsGroupName { get; set; }
        [Required]
        [MaxLength(50)]
        public string ItemsGroupNameEN { get; set; }
        [Required]
        [MaxLength(50)]
        public string ItemsGroupNameRU { get; set; }
        [ForeignKey("ParentGroup")]
        public Guid? ParentItemsGroupID { get; set; }
        public ItemsGroup? ParentItemsGroup { get; set; }
        public List<ItemsGroup> ChildItemsGroups { get; set; }
        public List<Item> Items { get; set; }

        public ItemsGroup()
        {
            Guid ID = Guid.NewGuid();
            ChildItemsGroups = new List<ItemsGroup>();
            Items = new List<Item>();
        }


    }
}
