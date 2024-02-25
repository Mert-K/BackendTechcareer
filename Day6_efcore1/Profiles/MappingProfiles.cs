using AutoMapper;
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
            CreateMap<Branch, BranchDto>(); //Bu satır ve alttaki 2 satır daha "System.Text.Json.JsonException: A possible object cycle was detected" hatasını kırmak için yazılan BranchDto class'ına Branch'ı çevirmek için yazıldı
            CreateMap<Outfit, OutfitDto>();
            CreateMap<Team, TeamDto>();
        }
    }
}
