using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HIS.AutoMappers
{
    public class ObjectMapper
    {
        private static IMapper _instance;
        public static IMapper Mapper
        {
            get { return _instance ?? throw new InvalidOperationException("Mapper not initialized."); }
            private set { _instance = value; }
        }

        public static void Configure()
        {
            if (_instance != null)
                throw new InvalidOperationException("Already configured");

            var config = new MapperConfiguration(
                cfg =>
                {
                    cfg.AddProfile<AutoMapperConfiguration>();
                    // Add more profiles and other mapping
                });
            _instance = config.CreateMapper();
        }
    }
}
