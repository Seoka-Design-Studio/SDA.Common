using AutoMapper;


namespace SDA.Common.Configuration
{
    public class GlobalMapping : Profile
    {
        public GlobalMapping()
        {
            CreateMap<DataModelBase, ServiceModelBase>()
                .ForMember(dst => dst.LastUserModified, opts => opts.MapFrom(x => x.LastUserUpdated))
                .ForMember(dst => dst.CreatedAt, opts => opts.MapFrom(x => x.CreatedDate))
                .ForMember(dst => dst.LastModified, opts => opts.MapFrom(x => x.LastUpdated))
                .ForMember(dst => dst.DeletedAt, opts => opts.MapFrom(x => x.DeletedDate))
                .ReverseMap();
            CreateMap<AssociativeModelBase, ServiceModelBase>()
                .ForMember(dst => dst.LastUserModified, opts => opts.MapFrom(x => x.LastUserUpdated))
                .ForMember(dst => dst.CreatedAt, opts => opts.MapFrom(x => x.CreatedDate))
                .ForMember(dst => dst.LastModified, opts => opts.MapFrom(x => x.LastUpdated))
                .ForMember(dst => dst.DeletedAt, opts => opts.MapFrom(x => x.DeletedDate))
                .ReverseMap()
                .AfterMap((src, dst) =>
                {
                    src.Id = string.Empty;
                });
        }
    }
}
