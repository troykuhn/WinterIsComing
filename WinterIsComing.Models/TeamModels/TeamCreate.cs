﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing.Data;
using WinterIsComing.Models.CharacterModels;

namespace WinterIsComing.Models.TeamModels
{
    public class TeamCreate
    {
        [Required]
        public string TeamName { get; set; }
    }
}
