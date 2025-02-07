using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel.Attributes;


namespace Excel.Data_Access_layer.Entity
{
    
        public class Excel_Data
    {
            [ExcelColumn("id")]
            public int Id { get; set; }
            [ExcelColumn("Country or region")]
            public string? Country_or_region { get; set; }
            [ExcelColumn("Score")]
            public decimal Score { get; set; }
            [ExcelColumn("GDP per capita")]//GDP meanes Gross Domestic Product
            public decimal Average { get; set; } = 0;
            [ExcelColumn("Social support")]
            public decimal Social_support { get; set; }
            [ExcelColumn("Healthy life expectancy")]
            public decimal Health { get; set; }
            [ExcelColumn("Freedom to make life choices")]
            public decimal Freedom_to_make_life_choices { get; set; }
            [ExcelColumn("Generosity")]
            public decimal Generosity { get; set; }
            [ExcelColumn("Perceptions of corruption")]
            public decimal Perceptions_of_corruption { get; set; }

        }
    
}
