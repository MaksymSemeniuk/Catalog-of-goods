using Catalog.Core;
using Catalog.Repository.Converters;
using Catalog.Repository.Dto;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Catalog.Repository
{
    public class UpdateRepository
    {
        private readonly CatalogContext _ctx;
        private readonly IConfiguration _configuration;

        public UpdateRepository(CatalogContext ctx, IConfiguration configuration)
        {
            _ctx = ctx;
            _configuration = configuration;
        }

        public async Task<List<string>> UpdateAsync()
        {
            HttpClient client = new HttpClient();
            var url = _configuration["Update:GithubUrl"];
            var jsonSerializerOptions = new JsonSerializerOptions();
            jsonSerializerOptions.Converters.Add(new IntJsonConverter());

            var data = await client.GetStringAsync(url);
            Console.WriteLine(data);
            data = data.Replace("NaN", "0");

            var list = JsonSerializer.Deserialize<List<CategoryReadJson>>(data, jsonSerializerOptions);
            // var existing = _ctx.Lesson.ToList();
            var existing = _ctx.Categories.ToList();
            foreach (var item in list)


            {
                if (!existing.Any(x => x.CategoryNumber == item.Category))
                {
                    //messageList.Add($"Додано дані за {item.Date.Value.ToString("dd.MM.yyyy")}.");

                    await _ctx.Categories.AddRangeAsync(new List<Category> {
                        new Category
                        {
                            CategoryNumber=item.Category,
                            CategoryId=item.Category
                          /* Date = item.Date.Value,
                            Type = await _ctx.EquipmentTypes.FindAsync(1),
                            Count = item.Aircraft*/
                        },

                    });

                }
            }
            await _ctx.SaveChangesAsync();
            return new List<string> { url, $"count{list.Count}" };
        }


    }
}
