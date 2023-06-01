using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgisayar_Toplama_Otomasyonu
{
    public partial class Bilgisayar_bakim_main : Form
    {
        public Bilgisayar_bakim_main()
        {
            InitializeComponent();
        }

        private void Bilgisayar_bakim_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Bilgisayar_bakim bilgisayar_Bakim = new Bilgisayar_bakim();

            if (cmbox_anaSorun.Text.Equals("") || cmbox_kacYil.Text.Equals("") || cmbox_nasilBasladi.Text.Equals(""))
            {
                MessageBox.Show("Lutfen Kutucukların Tamamını Doldurun", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (cmbox_anaSorun.Text.Contains("1"))
                {
                    bilgisayar_Bakim.rtxt_anaProblem.Text = "Bilgisayarınızın start almaması birçok farklı nedenle olabilir. Sorunun kaynağını bulmak için aşağıdaki adımları izleyebilirsiniz:\r\n\r\n1. Güç kaynağı kontrolü yapın: Bilgisayarınızın güç kaynağı doğru şekilde takılı mı? Güç kablosu hasar görmüş veya bağlantıları gevşek mi? Bunları kontrol edin.\r\n\r\n2. Donanım bileşenlerini kontrol edin: Bilgisayarınızın donanım bileşenleri doğru şekilde takılı mı? Bellek, sabit disk, grafik kartı vb. bileşenleri kontrol edin. Bileşenlerin bağlantılarını kontrol edin ve gerekiyorsa yeniden takın.\r\n\r\n3. BIOS ayarlarını kontrol edin: BIOS ayarlarının doğru olduğundan emin olun. Bazı durumlarda, yanlış BIOS ayarları nedeniyle bilgisayarınız başlatılamayabilir.\r\n\r\n4. Virüs taraması yapın: Bilgisayarınızı güncel bir antivirüs programıyla taramak, bazı virüslerin neden olduğu başlatma sorunlarını çözebilir.\r\n\r\n5. Windows Kurtarma Ortamı: Bilgisayarınızın başlatma sorunlarını gidermek için Windows kurtarma ortamını kullanabilirsiniz. Windows kurtarma ortamına erişmek için bilgisayarınızı başlatın ve F8 tuşuna basın.\r\n\r\nEğer yukarıdaki adımlar sorununuzu çözmediyse, donanım sorunları olabilir ve bir teknik destek almanız gerekebilir.";
                }
                else if (cmbox_anaSorun.Text.Contains("2"))
                {
                    bilgisayar_Bakim.rtxt_anaProblem.Text = "Bilgisayarınız açılıyor ancak monitörünüzde görüntü alamıyorsanız, sorun muhtemelen monitörünüzde veya ekran kartınızda olabilir. İşte çözmenize yardımcı olabilecek bazı adımlar:\r\n\r\nMonitör kablosunu kontrol edin: Monitörünüzle bilgisayarınız arasındaki kablo bağlantısını kontrol edin. Kabloda herhangi bir kırılma, ezilme veya gevşeklik varsa, bağlantının sağlam olduğundan emin olmak için kabloyu yeniden takın veya değiştirin.\r\n\r\nMonitörünüzü kontrol edin: Monitörünüzün güç düğmesinin açık olduğundan ve doğru giriş ayarlarının yapıldığından emin olun. Monitörünüzün menüsünde bulunan giriş seçeneğini doğru seçtiğinizden emin olun.\r\n\r\nEkran kartınızı kontrol edin: Ekran kartınızı kontrol edin ve doğru şekilde takıldığından emin olun. Bazı bilgisayarlar, entegre bir grafik kartı ve ayrı bir ekran kartı bulundurabilir. Eğer öyleyse, monitör kablonuzun ayrı bir ekran kartına bağlı olup olmadığını kontrol edin.\r\n\r\nBIOS ayarlarını kontrol edin: Bilgisayarınızın BIOS ayarlarını kontrol edin ve ekran kartınızın doğru şekilde tanımlandığından emin olun. Eğer bir sorun varsa, varsayılan ayarlara geri dönebilirsiniz.\r\n\r\nDiğer çıkışlarınızı deneyin: Eğer yukarıdaki adımlar sorunu çözmediyse, başka bir monitörle veya TV'nizdeki HDMI bağlantısı gibi başka bir çıkışla deneyin. Bu şekilde, monitörünüz veya ekran kartınızla ilgili bir sorun olup olmadığını anlayabilirsiniz.\r\n\r\nServis merkezine başvurun: Yukarıdaki adımlar sorunu çözmediyse, bilgisayarınızın bir servis merkezinde kontrol ettirilmesi gerekebilir.\r\n\r\nBu adımların herhangi biri sorunu çözemezse, sorunun daha ciddi bir teknik sorun olabileceğini ve bir uzmanın yardımına ihtiyaç duyabileceğinizi unutmayın.";
                }
                else if (cmbox_anaSorun.Text.Contains("3"))
                {
                    bilgisayar_Bakim.rtxt_anaProblem.Text = "Bilgisayarınız açılıyor ancak görüntü kalitesi düşükse, aşağıdaki adımları deneyebilirsiniz:\r\n\r\n1. Monitör kablosunun doğru bir şekilde bağlı olduğundan emin olun.\r\n2. Monitörünüzün ayarlarını kontrol edin ve doğru çözünürlüğü ve tarama frekansını ayarladığınızdan emin olun. Bu ayarları kontrol etmek için monitör kullanım kılavuzunuza başvurabilirsiniz.\r\n3. Ekran kartı sürücülerinizi güncellediğinizden emin olun. Yeni bir güncelleme varsa, bilgisayarınıza indirin ve kurun.\r\n4. Ekran kartınızın sürücülerini tamamen kaldırıp yeniden yüklemeyi deneyebilirsiniz.\r\n5. Monitörünüzde görüntü bozulması varsa, monitörünüzü başka bir bilgisayarda deneyerek sorunu belirleyebilirsiniz. Monitör sorunu varsa, bir teknik servise götürmeniz gerekebilir.\r\n\r\nBu adımları denedikten sonra hala bir çözüm bulamazsanız, teknik destek almanız gerekebilir.";
                }
                else if (cmbox_anaSorun.Text.Contains("4"))
                {
                    bilgisayar_Bakim.rtxt_anaProblem.Text = "Bilgisayarın olur olmadık yerde kapanması birçok farklı nedenle ilgili olabilir. Bazı olası nedenler şunlar olabilir:\r\n\r\n1. Isınma: Bilgisayarın içindeki bileşenlerin aşırı ısınması, bilgisayarın kendini korumak için kendini kapatmasına neden olabilir. Bunu önlemek için bilgisayarın tozunu düzenli olarak temizlemek ve fanlarını çalıştığından emin olmak önemlidir.\r\n\r\n2. Güç kaynağı sorunları: Bilgisayarın güç kaynağı sorunları, bilgisayarın aniden kapanmasına neden olabilir. Bu nedenle, güç kaynağının çalıştığından emin olmak için kontrol edilmelidir.\r\n\r\n3. Virüsler: Bilgisayarın virüslerle enfekte olması, sistemin çökmesine ve aniden kapanmasına neden olabilir. Bu nedenle, güncel bir antivirüs programı kullanarak düzenli olarak tarama yapmak önemlidir.\r\n\r\n4. Yazılım sorunları: Bazı yazılım sorunları, bilgisayarın aniden kapanmasına neden olabilir. Bu nedenle, sürücülerin ve işletim sisteminin güncel olduğundan emin olmak ve sistemdeki hataları düzeltmek için düzenli olarak bakım yapmak önemlidir.\r\n\r\n5. Donanım sorunları: Bazı donanım sorunları, bilgisayarın aniden kapanmasına neden olabilir. Bu nedenle, bilgisayarın donanım bileşenlerinin düzgün çalıştığından emin olmak için bir teknisyene danışmak gerekebilir.";
                }
                else if (cmbox_anaSorun.Text.Contains("5"))
                {
                    bilgisayar_Bakim.rtxt_anaProblem.Text = "Mavi ekran hatası, Windows işletim sistemi kullanıcıları için oldukça yaygın bir sorundur. Bu hata, bilgisayarınızda bir sistem hatası veya donanım sorunu olduğunu belirtir ve genellikle \"Blue Screen of Death (BSOD)\" olarak adlandırılır.\r\n\r\nMavi ekran hatası alındığında, hatanın belirtileri ve kodları hakkında bazı bilgiler ekranda görüntülenir. Bu bilgiler, sorunu anlamak ve çözmek için önemlidir.\r\n\r\nMavi ekran hatası nedenleri çok çeşitli olabilir ve bazen birden fazla neden bir arada mevcut olabilir. Bunlar arasında:\r\n\r\n- Sistem dosyalarının veya donanım sürücülerinin hasar görmesi\r\n- Yetersiz bellek veya sabit disk kapasitesi\r\n- Virüs veya kötü amaçlı yazılım enfeksiyonu\r\n- Donanım sorunları, örneğin RAM veya sabit disk arızaları\r\n- Aşırı ısınma veya fan sorunları\r\n- BIOS veya diğer sistem ayarları sorunları\r\n\r\nMavi ekran hatası sorunlarını çözmek için öncelikle hatanın kodunu ve belirtilerini anlamak gerekir. Ardından, donanım veya yazılım sorunlarını teşhis etmek ve düzeltmek için bazı adımlar izlenebilir. Bu adımlar arasında, sistem dosyalarının onarımı, güncelleme veya yeniden yükleme, virüs taraması ve donanım sorunlarının kontrolü yer alabilir.\r\n\r\nAncak, mavi ekran hatası sorunları çok karmaşık olabilir ve bazen uzman yardımı gerektirebilir. Bu nedenle, sorununuzu belirlemekte veya çözmekte zorlanıyorsanız, bir bilgisayar teknisyeni veya yazılım uzmanından yardım almanız önerilir.";
                }
                else if (cmbox_anaSorun.Text.Contains("6"))
                {
                    bilgisayar_Bakim.rtxt_anaProblem.Text = "Bilgisayarınızda bazı bileşenlerin doğru çalışmadığını fark ederseniz, bunun nedeni çeşitli olabilir. Öncelikle, donanım bileşenlerinin doğru şekilde takıldığından emin olmak için bilgisayarınızı açıp kontrol edebilirsiniz. Ayrıca, sürücülerin güncel olduğundan emin olmak için aygıt yöneticisine bakabilirsiniz. \r\n\r\nEğer donanım bileşenlerinin doğru çalışmadığından eminseniz, sorunun nedeni birkaç farklı şey olabilir. Örneğin:\r\n\r\n- Sürücülerin güncel olmaması: Bilgisayarınızın bileşenleri için doğru sürücülerin yüklü olduğundan emin olun. Sürücülerin güncel olmaması, bileşenlerin doğru çalışmamasına neden olabilir.\r\n- Isınma sorunları: Bilgisayarınızın aşırı ısınması da bileşenlerin doğru çalışmasını engelleyebilir. Bu nedenle, bilgisayarınızın fanlarının doğru çalıştığından ve içindeki tozların temizlendiğinden emin olun.\r\n- Bileşenlerin arızalanması: Bileşenlerin fiziksel olarak hasar görmüş olması veya arızalanmış olması, doğru çalışmalarını engelleyebilir. Bu durumda, arızalı bileşenlerin değiştirilmesi gerekebilir.\r\n- Elektrik kaynaklı sorunlar: Bazı durumlarda, güç kaynağı veya diğer elektrik bileşenlerinde sorunlar olabilir. Bu da bileşenlerin doğru çalışmasını engelleyebilir.\r\n\r\nBu sorunu çözmek için, sorunun neden kaynaklandığını belirlemek ve ardından doğru bir şekilde çözmek için profesyonel bir teknik servis ile iletişime geçmeniz önerilir.";
                }
                else if (cmbox_anaSorun.Text.Contains("7"))
                {
                    bilgisayar_Bakim.rtxt_anaProblem.Text = "Bilgisayarın USB çıkışları çalışmıyorsa, aşağıdaki yöntemleri deneyebilirsiniz:\r\n\r\n1. Diğer cihazlarda deneyin: USB bağlantısı yapmak istediğiniz cihazı başka bir bilgisayarda deneyin. Eğer cihaz diğer bilgisayarlarda çalışıyorsa sorunun bilgisayarınızda olduğunu söyleyebilirsiniz.\r\n\r\n2. Yeniden başlatın: Bilgisayarınızı yeniden başlatın ve USB bağlantısını tekrar deneyin. Bazı durumlarda, sadece bir yeniden başlatma sorunu çözebilir.\r\n\r\n3. Sürücüleri güncelleştirin: USB bağlantı noktalarınızın sürücülerini güncelleştirin. Bunu yapmak için, Bilgisayarım > Yönet > Aygıt Yöneticisi seçeneklerini seçin ve USB sürücülerini bulun. Sürücüleri sağ tıklayın ve Güncelleştir seçeneğini seçin.\r\n\r\n4. USB ayarlarını kontrol edin: Bazı durumlarda, bilgisayarınızın USB ayarları yanlış yapılandırılmış olabilir. Bu durumda, BIOS ayarlarınızda USB desteğinin etkinleştirildiğinden emin olun.\r\n\r\n5. Bağlantı noktalarını temizleyin: USB bağlantı noktalarınızı temizleyin. Bu, bağlantı noktalarındaki toz veya kirin birikmesini önleyebilir ve bağlantı noktalarınızın daha iyi çalışmasını sağlayabilir.\r\n\r\n6. USB bağlantı noktalarını değiştirin: USB bağlantı noktalarınızın birisi arızalı olabilir. Bu durumda, farklı bir USB bağlantı noktasını deneyebilirsiniz. Eğer başka bir USB bağlantı noktası da çalışmazsa, bilgisayarınızın donanımı arızalı olabilir.\r\n\r\n7. Teknik destek alın: Yukarıdaki adımları denedikten sonra bile USB bağlantı noktalarınız çalışmıyorsa, teknik destek almanız gerekebilir.";
                }
                else if (cmbox_anaSorun.Text.Contains("8"))
                {
                    bilgisayar_Bakim.rtxt_anaProblem.Text = "Bilgisayarınızın internete bağlanmamasının birden fazla sebebi olabilir. Bazı olası nedenleri ve çözüm önerileri aşağıda verilmiştir:\r\n\r\n1. Kablosuz ağ bağlantısı sorunları: Eğer kablosuz bir ağa bağlanmaya çalışıyorsanız, ağ adı ve şifre doğru girildiğinden emin olun. Ayrıca, sinyal gücünün yeterli olduğundan emin olmak için bilgisayarınızı erişim noktasına yakın bir yere taşıyabilirsiniz.\r\n\r\n2. Kablolu ağ bağlantısı sorunları: Kablolu bir ağa bağlanıyorsanız, kablo bağlantılarının doğru şekilde yapıldığından emin olun. Ethernet kablosunun zarar görmüş olması, bağlantı noktasında bir sorun olması veya ağ donanımı sorunları olabilir.\r\n\r\n3. IP adresi sorunları: Bilgisayarınızın ağ yapılandırmasında IP adresi sorunları varsa, internete bağlanamazsınız. DHCP etkinleştirilmişse, bilgisayarınız otomatik olarak bir IP adresi alır. IP adresi ayarlarını kontrol etmek için ağ bağlantıları ayarlarına gidin.\r\n\r\n4. Güvenlik duvarı ayarları: Güvenlik duvarı ayarlarının internet bağlantısını engellemesi mümkündür. Güvenlik duvarını kontrol edin ve internete erişim izni verin.\r\n\r\n5. Sürücü sorunları: Bilgisayarınızın ağ kartı sürücüleri güncel değilse veya doğru şekilde yüklenmemişse, internete bağlanamazsınız. Aygıt Yöneticisi'ni açarak ağ kartının sürücülerinin güncel olduğundan emin olun.\r\n\r\nBu adımları denedikten sonra hala internete bağlanamıyorsanız, modem veya erişim noktası gibi ağ donanımınızda bir sorun olabilir. Bu durumda, internet sağlayıcınızla iletişime geçmeniz ve onlardan destek istemeniz gerekebilir.";
                }
                else if (cmbox_anaSorun.Text.Contains("9"))
                {
                    bilgisayar_Bakim.rtxt_anaProblem.Text = "Bilgisayarın yavaşlamasının birkaç nedeni olabilir. Bunlardan bazıları şunlardır:\r\n\r\n1. Virüs ve kötü amaçlı yazılımlar: Bilgisayarınızda virüs veya kötü amaçlı yazılımlar varsa, sisteminiz yavaşlayabilir. Güvenlik yazılımı kullanarak sisteminizi tarayarak ve kötü amaçlı yazılımları kaldırarak başlayabilirsiniz.\r\n\r\n2. Düşük bellek: Bilgisayarınızın belleği yetersizse, sistem yavaşlayabilir. Daha fazla bellek ekleyerek bu sorunu çözebilirsiniz.\r\n\r\n3. Bozuk sabit disk: Sabit diskler zamanla bozulabilir ve dosyalarınızın okunmasını ve yazılmasını yavaşlatabilir. Sabit diskinizi kontrol ederek veya değiştirerek sorunu çözebilirsiniz.\r\n\r\n4. Çok sayıda program ve uygulama: Bilgisayarınızda çok sayıda program ve uygulama yüklü ise, sistem yavaşlayabilir. Kullanmadığınız programları kaldırarak veya gereksiz dosyaları silerek bu sorunu çözebilirsiniz.\r\n\r\n5. Güncelleştirmelerin eksik olması: Bilgisayarınızda güncellemeleri yüklememiş olabilirsiniz. Bu, sisteminizin yavaşlamasına neden olabilir. Güncellemeleri yükleyerek bu sorunu çözebilirsiniz.\r\n\r\n6. Sıcaklık sorunları: Bilgisayarınızın içindeki bileşenlerin sıcaklığı fazla yükselirse, sistem yavaşlayabilir. İç temizlik yaparak, fanları temizleyerek veya daha yüksek performanslı bir soğutma sistemine yatırım yaparak bu sorunu çözebilirsiniz. \r\n\r\nBu önerilerin hepsini denediğinizde bile hala sorun devam ediyorsa, bir uzmandan yardım almanız gerekebilir.";
                }
                else if (cmbox_anaSorun.Text.Contains("10"))
                {
                    bilgisayar_Bakim.rtxt_anaProblem.Text = "Bilgisayarınızın ses çıkışları çalışmıyorsa, aşağıdaki adımları deneyebilirsiniz:\r\n\r\n1. Hoparlörlerinizi ve kablolama bağlantılarını kontrol edin: Hoparlörlerinizin güç kablosu prize takılı mı? Ses kablosu doğru bir şekilde bilgisayara mı bağlanmış?\r\n\r\n2. Ses ayarlarını kontrol edin: Bilgisayarınızın ses ayarlarına girerek hoparlörlerin varsayılan cihaz olarak ayarlanmış olup olmadığını kontrol edin. Ayrıca, hoparlörlerin ses düzeyi ayarlarını kontrol edin.\r\n\r\n3. Sürücüleri güncelleyin: Bilgisayarınızdaki ses kartı sürücüleri güncel değilse, ses çıkışlarının çalışmamasına neden olabilir. Ses kartı üreticisinin web sitesinden en son sürücüleri indirin ve yükleyin.\r\n\r\n4. Ses kartınızı kontrol edin: Hoparlörlerinizin bağlı olduğu ses kartınızı kontrol edin. Kartta bir arıza varsa, bu da ses çıkışlarının çalışmamasına neden olabilir.\r\n\r\n5. Başka bir cihazda deneyin: Hoparlörlerinizi başka bir cihazda deneyin. Eğer hoparlörler sorunsuz bir şekilde çalışıyorsa, sorun muhtemelen bilgisayarınızın ses kartında veya sürücülerinde olabilir.\r\n\r\nYukarıdaki adımlar sorunu çözemezse, bilgisayarınızın teknik desteğine başvurmanızı öneririz.";
                }
                else
                {
                    bilgisayar_Bakim.rtxt_anaProblem.Text = "Eğer sorununuz listede yoksa teknik desteğe başvurmanızı öneririz";
                }

                if (cmbox_nasilBasladi.Text.Contains("1"))
                {
                    bilgisayar_Bakim.rtxt_nasilBasladi.Text = "Bilgisayarınızın bir anda bozulmasının birçok nedeni olabilir. Donanım sorunları, yazılım sorunları, elektrik kesintileri, aşırı ısınma gibi faktörler bir anda bozulmaya neden olabilirler. Bilgisayarınızın ne tür bir sorunla karşı karşıya olduğunu belirlemek için öncelikle hangi adımda takıldığınızı veya hangi sorunu yaşadığınızı belirlemelisiniz. Daha sonra sorununuzu daha detaylı bir şekilde araştırabilirsiniz.";

                }
                else if (cmbox_nasilBasladi.Text.Contains("2"))
                {
                    bilgisayar_Bakim.rtxt_nasilBasladi.Text = "Bilgisayarınızın ara ara bozulup geri düzeldiği bir durumda, birkaç farklı sebep olabilir:\r\n\r\nYazılım sorunları: Bilgisayarınızın yazılımı çeşitli nedenlerle çökebilir veya bozulabilir. Bu sorunlar genellikle yazılım güncelleştirmeleri veya çeşitli uygulamaların yüklenmesi nedeniyle oluşabilir.\r\n\r\nDonanım sorunları: Bilgisayarınızın donanımı bazen yanıt vermeyebilir veya çalışmayı durdurabilir. Bu sorunlar genellikle donanım bileşenlerinin yaşlanması veya hasar görmesi nedeniyle oluşabilir.\r\n\r\nSıcaklık sorunları: Bilgisayarınızın içindeki sıcaklıkların yükselmesi, sisteminizin kararsız hale gelmesine neden olabilir. Bu nedenle, bilgisayarınızın fanları veya soğutucuları çalışmayabilir veya tozlu olabilir.\r\n\r\nElektrik sorunları: Elektrik kesintileri veya dalgalanmaları da bilgisayarınızın ara ara bozulmasına neden olabilir.\r\n\r\nBu nedenlerden herhangi biri, bilgisayarınızın ara ara bozulup geri düzelmesine neden olabilir. Ancak, sorunun kök nedenini bulmak için, bilgisayarınızın tam olarak ne zaman bozulduğunu, ne zaman geri düzeldiğini ve hangi aktiviteleri yaptığınızı takip etmek önemlidir. Bu, sorunu tanımlamanıza ve çözüm bulmanıza yardımcı olacaktır.";

                }
                else if (cmbox_nasilBasladi.Text.Contains("3"))
                {
                    bilgisayar_Bakim.rtxt_nasilBasladi.Text = "Bilgisayarınızın normal bir şekilde kapatıldıktan sonra bozulması, farklı birkaç nedene bağlı olabilir.\r\n\r\nÖncelikle, bilgisayarınızın donanımı ile ilgili bir sorun olabilir. Örneğin, sabit diskinizde bir sektör hatası oluştuysa veya RAM'inizde bir hata varsa, bilgisayarınız açılmayabilir veya normal çalışmayabilir.\r\n\r\nAyrıca, işletim sistemi yazılımında bir sorun da olabilir. Bu durumda, bir yazılım güncellemesi veya bilgisayarınızı geri yükleme işlemi gibi birkaç adımı izleyerek sorunu gidermeyi deneyebilirsiniz.\r\n\r\nSon olarak, bazı güvenlik yazılımları veya kötü amaçlı yazılımların bilgisayarınızı etkilemesi de mümkündür. Bilgisayarınızın antivirüs yazılımını güncelleyerek veya bir tarama yaparak bu sorunu çözmeyi deneyebilirsiniz.";

                }
                else if (cmbox_nasilBasladi.Text.Contains("4"))
                {
                    bilgisayar_Bakim.rtxt_nasilBasladi.Text = "Eğer bilgisayarınız fiziksel bir hasar aldıysa, öncelikle bilgisayarınızı kullanmadan önce hasarın ne olduğunu ve hangi bileşenlerin etkilendiğini belirlemek için dikkatli bir şekilde incelemeniz gerekir. Örneğin, ekranda çatlak veya kırılma varsa, ekranın değiştirilmesi gerekebilir.\r\n\r\nBunun yanı sıra, bilgisayarın iç bileşenlerindeki hasarları tespit etmek için de iç kısmını açmanız gerekebilir. Ancak, bilgisayarınızı açmadan önce bir uzmana danışmanız önerilir. Fiziksel hasarın ne olduğuna ve ne kadar ciddi olduğuna bağlı olarak, hasarlı bileşenlerin onarılması veya değiştirilmesi gerekebilir.";

                }
                else
                {
                    bilgisayar_Bakim.rtxt_nasilBasladi.Text = "Teknik Servise Başvurmanızı Öneriyoruz";

                }
                if (cmbox_kacYil.Text.Contains("1"))
                {
                    bilgisayar_Bakim.rtxt_pcYas.Text = "Bilgisayarların ömrü kullanıma, marka ve modeline, kullanım koşullarına ve bakımına bağlı olarak değişebilir. Eğer garanti süreniz hala geçerliyse, cihazınızı garantiye göndererek ücretsiz olarak onarım hizmeti alabilirsiniz. Aksi takdirde, bir bilgisayar tamircisine başvurarak sorunu belirleyip onarım için fiyat teklifi alabilirsiniz.";
                }
                else if (cmbox_kacYil.Text.Contains("2"))
                {
                    bilgisayar_Bakim.rtxt_pcYas.Text = "Bir bilgisayarın ömrü, kullanım sıklığı, marka/modeli, kalitesi ve bakımı gibi faktörlere bağlı olarak değişebilir. Normal şartlarda, bir bilgisayarın ömrü ortalama 5-6 yıl olabilir, ancak bazı durumlarda daha kısa veya daha uzun sürebilir.";
                }
                else if (cmbox_kacYil.Text.Contains("3"))
                {
                    bilgisayar_Bakim.rtxt_pcYas.Text = "Öncelikle, bilgisayarınızın garanti süresi hala geçerliyse, üreticiye başvurabilirsiniz. Eğer garanti süresi geçtiyse, bir teknik servis merkezine ya da bilgisayar tamiri yapan bir mağazaya başvurabilirsiniz.\r\n\r\nAyrıca, sorunu kendiniz çözmek isterseniz, öncelikle ne tür bir sorunla karşı karşıya olduğunuzu belirlemeniz gerekir. Bilgisayarınız açılmıyorsa, donanımsal bir sorun olabilir. Ekranda hata mesajları veya mavi ekran görüyorsanız, yazılımsal bir sorun olabilir.";
                }
                else if (cmbox_kacYil.Text.Contains("4"))
                {
                    bilgisayar_Bakim.rtxt_pcYas.Text = "Bilgisayarınızın 8 yıl boyunca kullanılması, özellikle yoğun bir kullanım söz konusuysa, çeşitli sorunlara neden olabilir. Bilgisayarların ömrü, kullanılan bileşenlere, sıklıkla kullanımına, bakımına ve genel olarak kullanıcıların nasıl kullandığına bağlıdır.\r\n\r\n";
                }
                else
                {
                    bilgisayar_Bakim.rtxt_pcYas.Text = "Bilgisayarınızın 10 yıl boyunca kullanılması, birçok donanımsal veya yazılımsal soruna neden olabilir. Bilgisayarların ömrü, kullanılan bileşenlere, sıklıkla kullanımına, bakımına ve kullanıcıların nasıl kullandığına bağlıdır.\r\n\r\nBilgisayarınızın donanımsal sorunları olabilir. Uzun süreli kullanımın bir sonucu olarak, bilgisayarınızın sabit diski, RAM'i, anakartı veya diğer bileşenleri arızalanmış olabilir. Ayrıca, eski bilgisayarların güç kaynakları da aşınabilir ve sorunlara neden olabilir.";
                }
                this.Hide();
                bilgisayar_Bakim.Show();
            }
    }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            if (Main.girisYapildiMi == 1)
            {
                Bakim_Toplama_ayrimi ayrimNesne = new Bakim_Toplama_ayrimi();
                ayrimNesne.lbl_hesapInfo.Text = Main.Kullanici_eposta;
                ayrimNesne.Show();
                this.Hide();
            }
            else
            {
                Bakim_Toplama_ayrimi ayrimNesne = new Bakim_Toplama_ayrimi();
                ayrimNesne.Show();
                this.Hide();
            }
        }

    }
}
