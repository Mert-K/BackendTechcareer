﻿using AutoMapper;
using Day6_efcore1.Dtos.Requests;
using Day6_efcore1.Dtos.Responses;
using Day6_efcore1.Models;

namespace Day6_efcore1.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<CreatePlayerRequestDto, Player>();
            CreateMap<UpdatePlayerRequestDto, Player>();
            CreateMap<Player, PlayerResponseDto>(); //Player'ı PlayerResponseDto'ya çevirme profili
        }
    }
}
