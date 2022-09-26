using Newtonsoft.Json;
using RestorantiApplication.Generics.Logs;
using RestorantiApplication.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestorantiApplication.Views
{
    public partial class Categorys : Form
    {
        private HttpClient _client;
        private readonly static string baseUrl = ConfigurationManager.AppSettings["category"].ToString();
        public Categorys()
        {
            InitializeComponent();
        }

        private void Categorys_Load(object sender, EventArgs e)
        {
            _client = new HttpClient();
            HttpResponseMessage result = _client.GetAsync($"{baseUrl}/Category/List").Result;

            var categorys = JsonConvert.DeserializeObject<List<Category>>(result.Content.ReadAsStringAsync().Result);
            if (categorys?.Count > 0)
            {
                foreach (var i in categorys)
                {
                    //Passar como parâmetro o ID da categoria
                    ListViewItem item = new ListViewItem(i.Id.ToString());
                    //Nome da categoria
                    item.SubItems.Add(i.Name);
                    //Status da categoria
                    item.SubItems.Add(i.Status.ToString());
                    ListCategorys.Items.Add(item);
                }
            }
        }
    }
}
