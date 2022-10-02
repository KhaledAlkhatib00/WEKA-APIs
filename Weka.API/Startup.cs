using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weka.Core.Common;
using Weka.Core.IRepository;
using Weka.Core.Repository;
using Weka.Core.Service;
using Weka.Infra.Common;
using Weka.Infra.Repository;
using Weka.Infra.Service;

namespace Weka.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Link With Anguler
            services.AddCors(corsOptions =>
            {
                corsOptions.AddPolicy("policy",
                    builder =>
                    {
                        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                    });
            });


            services.AddControllers();
            services.AddScoped<IDbContext, DbContext>();
            
            //Repository
            services.AddScoped<IUserRepository,UserRepository>();
            services.AddScoped<IAboutUsRepository,AboutUsRepository>();
            services.AddScoped<IMessageRepository,MessageRepository>();
            services.AddScoped<IJWTRepository,JWTRepository>();
            services.AddScoped<ITestamonialRepository, TestamonialRepository>();
            services.AddScoped<IHomeRepository, HomeRepository>();
            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddScoped<IContactUsRepository, ContactUsRepository>();
            services.AddScoped<ILikeArticleRepository, LikeArticleRepository>();
            services.AddScoped<ICommentLikesRepository, CommentLikesRepository>();
            services.AddScoped<IFavoriteRepository, FavoriteRepository>();
            services.AddScoped<IBlockedRepository, BlockedRepository>();
            services.AddScoped<IReportsRopository, ReportsRopository>();
            services.AddScoped<ICommenttRepository, CommenttRepository>();
            services.AddScoped<IReferencessRepository, ReferencessRepository>();
            services.AddScoped<IVisaInfoRepository, VisaInfoRepository>();
            services.AddScoped<IBadWordRepository, BadWordRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IUserActivitysRopository, UserActivitysRopository>();
            //Service
            services.AddScoped<IUserService,UserService>();
            services.AddScoped<IMessageService, MessageService>();
            services.AddScoped<IAboutUsService, AboutUsService>();
            services.AddScoped<IJWTService, JWTService>();
            services.AddScoped<ITestamonialService, TestamonialService>();
            services.AddScoped<IHomeService, HomeService>();
            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<IContactUsService, ContactUsService>();
            services.AddScoped<ILikeArticleService, LikeArticleService>();
            services.AddScoped<ICommentLikesService, CommentLikesService>();
            services.AddScoped<IFavoriteService, FavoriteService>();
            services.AddScoped<IBlockedService, BlockedService>();
            services.AddScoped<IReportsService, ReportsService>();
            services.AddScoped<ICommenttService, CommenttService>();
            services.AddScoped<IReferencessService, ReferencessService>();
            services.AddScoped<IVisaInfoService, VisaInfoService>();
            services.AddScoped<IBadWordService, BadWordService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IUserActivityService, UserActivityService>();


            services.AddAuthentication(
               x =>
               {
                   x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                   x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
               }).AddJwtBearer(
               y =>
               {
                   y.RequireHttpsMetadata = false;
                   y.SaveToken = true;
                   y.TokenValidationParameters = new TokenValidationParameters
                   {
                       ValidateIssuerSigningKey = true,
                       IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("Secret Saif Key")),
                       ValidateIssuer = false,
                       ValidateAudience = false
                   };
               });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("policy");
            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
