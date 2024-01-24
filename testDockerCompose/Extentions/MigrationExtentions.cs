using Microsoft.EntityFrameworkCore;
using testDockerCompose.Data;

namespace testDockerCompose.Extentions
{
    public static class MigrationExtentions 
    {
        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using IServiceScope scope = app.ApplicationServices.CreateScope();
            
            using AppDbContext dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();

             dbContext.Database.Migrate();
            
        }
    }
}
