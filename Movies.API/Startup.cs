using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Movies.Core.Common;
using Movies.Core.Repository;
using Movies.Core.Service;
using Movies.Infra.Common;
using Movies.Infra.Repository;
using Movies.Infra.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
using Movies.Core.Settings;

namespace Movies.API
{
    public class Startup
    {
        //new
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        //new*
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
         
            //new*
            services.AddCors(options => 
            options.AddPolicy(name :MyAllowSpecificOrigins, builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;



            }).AddJwtBearer(y =>
            {
                y.RequireHttpsMetadata = false;
                y.SaveToken = true;
                y.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("[SECRET USED TO SIGN AND VERIFY JWT TOKENS, IT CAN BE ANY STRING]")),
                    ValidateIssuer = false,
                    ValidateAudience = false



                };
            });


            

            //Repository
            services.AddScoped<IDBContext, DBContext>();
            services.AddScoped<IExpensesRepository, ExpensesRepository>();
            services.AddScoped<IHistoryRepository, HistoryRepository>();
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<IMessengerRepository, MessengerRepository>();
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<ISliderRepository, SliderRepository>();
            services.AddScoped<ITasksRepository, TasksRepository>();
            services.AddScoped<ITestimonialRepository, TestimonialRepository>();
            services.AddScoped<IWebSiteRepository, WebSiteRepository>();
            services.AddScoped<IWorkingHoursRepository, WorkingHoursRepository>();
            services.AddScoped<IContactUsRepository, ContactUsRepository>();
            services.AddScoped<ICustomerListRepository, CustomerListRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IEvaluationRepository, EvaluationRepository>();
            services.AddScoped<IAboutUsRepository, AboutUsRepository>();
            services.AddScoped<IAccountantRepository, AccountantRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICheckInOutRepository, CheckInOutRepository>();
            services.AddScoped<ICommentsRepository, CommentsRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();

            //Services
            services.AddScoped<IExpensesService, ExpensesService>();
            services.AddScoped<IHistoryService, HistoryService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IMessengerService, MessengerService>();
            services.AddScoped<IMovieService, MovieService>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<ISliderService, SliderService>();
            services.AddScoped<ITasksService, TasksService>();
            services.AddScoped<ITestimonialService, TestimonialService>();
            services.AddScoped<IWebSiteService, WebSiteService>();
            services.AddScoped<IWorkingHoursService, WorkingHoursService>();
            services.AddScoped<IContactUsService, ContactUsService>();
            services.AddScoped<ICustomerListService, CustomerListService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IEvaluationService, EvaluationService>();
            services.AddScoped<IAboutUsService, AboutUsService>();
            services.AddScoped<IAccountantService, AccountantService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICheckInOutService, CheckInOutService>();
            services.AddScoped<ICommentsService, CommentsService>();
            services.AddScoped<ICustomerService, CustomerService>();

            services.AddScoped<IMailService, MailService>();
            services.Configure<MailSettings>(Configuration.GetSection("MailSettings"));
            services.AddTransient<IMailService, MailService>();


            services.AddControllers();

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

            app.UseAuthorization();
            //new
            app.UseCors(MyAllowSpecificOrigins);
            //new*
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
