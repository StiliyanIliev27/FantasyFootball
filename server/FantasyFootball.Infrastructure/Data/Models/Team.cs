﻿using System.ComponentModel.DataAnnotations;
using static FantasyFootball.Common.DatabaseModelsConstants.DataConstants.Team;

namespace FantasyFootball.Infrastructure.Data.Models
{
    public class Team
    {
        public Team()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Required]
        public string Id { get; set; }

        [Required]
        [Length(TeamNameMinLength, TeamNameMaxLength, 
            ErrorMessage = TeamNameLengthErrorMessage)]
        public string Name { get; set; } = null!;

        [Required]
        [Length(TeamHomeTownAndCountryMinLength, TeamHomeTownAndCountryMaxLength, 
            ErrorMessage = TeamHomeTownAndCountryErrorMessage)]
        public string HomeTown { get; set; } = null!;

        [Required]
        [Length(TeamHomeTownAndCountryMinLength, TeamHomeTownAndCountryMaxLength,
            ErrorMessage = TeamHomeTownAndCountryErrorMessage)]
        public string HomeCountry { get; set; } = null!;
        public string? TeamIconUrl { get; set; }
    }
}
