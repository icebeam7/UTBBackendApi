using UTBBackendApi.Services;
using UTBBackendApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace UTBBackendApi.Endpoints
{
    public static class StudentApi
    {
        static string endpoint = "/api/students";

        public static async void 
            MapStudentEndpoints(this WebApplication app)
        {
            app.MapGet(endpoint + "/All",
                async (IDbService dbs) => 
                    await dbs.GetAll<Student>());

            app.MapGet(endpoint + "/{id}", 
                async (IDbService dbs, int id) =>
                    await dbs.Get<Student>(id));

            app.MapPost(endpoint + "/Add",
                async (IDbService dbs, Student s) =>
                    await dbs.Add(s));
        }
    }
}
