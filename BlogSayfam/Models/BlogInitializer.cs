using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogSayfam.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {

        
            List<Blog> bloglar = new List<Blog>()
            {
                new Blog{Resim="~/Content/img/js.png",Baslik="Blog_1",Icerik="İçerik",eklenmeTarihi=DateTime.Today,IsHomepage=false},
                new Blog{Resim="~/Content/img/images.jpg",Baslik="Blog_2",Icerik="İçerik2",eklenmeTarihi=DateTime.Today,IsHomepage=true},
                new Blog{Resim="~/Content/img/back.png",Baslik="Blog_3",Icerik="İçerik3",eklenmeTarihi=DateTime.Today,IsHomepage=true},
                new Blog{Resim="~/Content/img/js.png",Baslik="Blog_4",Icerik="İçerik4",eklenmeTarihi=DateTime.Today,IsHomepage=true},
                new Blog{Resim="~/Content/img/back.png",Baslik="Blog_5",Icerik="Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit amet.. comes from a line in section 1.10.32.The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H.Rackham" ,eklenmeTarihi=DateTime.Today,IsHomepage=true},
                new Blog{Resim="~/Content/img/microsoft.jpg",Baslik="Microsoft Bing ile Corona virüsü canlı izleyin",Icerik="Dünya, Corona virüsü salgını ile uğraşırken şirketler insanları pandemi hakkında bilgilendirmek için araçlar yapıyor. Bugünün erken saatlerinde Microsoft, COVID-19 salgınını canlı izlemek için yaptığı yeni gösterge tablosunu yayınladı. Şirket, tablonun verilerini Dünya Sağlık Örgütü (WHO), ABD Hastalık Kontrol ve Önleme Merkezleri (CDC) ve Avrupa Hastalık Önleme ve Kontrol Merkezi gibi güvenilir kaynaklardan topladığını söyledi. Microsoft Bing‘den Michael Schechter, “Bing, geçtiğimiz hafta, COVID-19 verilerinden oluşan haritalama ve yetkili haber kaynağını oluşturmak için çalışmalara başlamıştı.” dedi.Google da, insanları Corona virüsü salgını hakkında bilgilendirmek için bir site oluşturdu. Bununla birlikte bu site, gösterge tablosu yerine ABD’de yaşayan insanlar için bir bilgi merkezi olmayı amaçlıyor.  Raporlara göre, Google’ın yeni yaptığı web sitesinden daha fazlası olacak çünkü Bing’in portalı COVID-19 semptomları hastalıkla ilişkili riskler ve yerel test merkezleri hakkındaki bilgileri de içerecek.Bing adresinden erişilebilen web sitesi dünyadaki her ülke için güncel enfeksiyon istatistiklerini gösteriyor. " ,eklenmeTarihi=DateTime.Today,IsHomepage=true}





            };
            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }

            
            context.SaveChanges();
            base.Seed(context);
        }
    }
}