# AVUÇ İÇİ İZİYLE POS ÖDEME SİSTEMİ
## Mantıksal Çerçeve Matrisi (Logical Framework Matrix)

---

## Proje: Avuç İçi Damar İzi Tanıma Teknolojisi Tabanlı Güvenli POS Ödeme Sistemi Geliştirilmesi

| Müdahale Mantığı – Projenin Kapsamı | Objektif Olarak Doğrulanabilir Göstergeler (Performans Ölçütleri) | Doğrulama Kaynakları | Varsayımlar / Riskler |
|---|---|---|---|
| **Genel Amaç (Overall Goal)**<br><br>Ödeme sistemlerinde güvenlik düzeyini artırırken kullanıcı deneyimini iyileştirerek sürdürülebilir ve yenilikçi finansal teknolojilerin gelişimine katkı sağlamak. | • Türkiye'deki ödeme dolandırıcılığı vakalarında azalma [(Yeni vaka sayısı – Eski vaka sayısı) / Eski vaka sayısı] ≥ %15 azalma (uzun vadede)<br>• Biyometrik ödeme kullanım oranı artışı ≥ %25<br>• Kullanıcı güvenlik algısı skoru (5'li Likert) ≥ 4.5<br>• Temassız ödeme teknolojilerine yatırım artışı ≥ %30 | • BDDK (Bankacılık Düzenleme ve Denetleme Kurumu) istatistikleri<br>• TBB (Türkiye Bankalar Birliği) ödeme sistemi raporları<br>• Sektör anketleri ve araştırma raporları<br>• Proje sonrası etki değerlendirme raporu | **Varsayımlar:**<br>• Türkiye'de dijital ödeme altyapısı gelişmeye devam eder<br>• Tüketicilerin biyometrik teknolojilere güveni artar<br>• Düzenleyici kurumlar biyometrik ödemeleri destekler<br><br>**Riskler:**<br>• Biyometrik verilere yönelik toplumsal kaygılar artabilir<br>• KVKK düzenlemeleri kısıtlayıcı olabilir |
| **Proje Amacı (Specific Purpose)**<br><br>Avuç içi damar izi tanıma teknolojisi kullanarak, kart ve şifre gerektirmeyen, yüksek güvenlikli, hızlı ve kullanıcı dostu bir POS ödeme sistemi geliştirmek ve 50 kullanıcı ile pilot test yapmak. | • Çalışır prototip sistem tamamlandı (%100 fonksiyonel)<br>• 50 kullanıcı sistemde kayıtlı ve test edildi<br>• Model doğruluk oranı (Accuracy) ≥ %99<br>• False Acceptance Rate (FAR) ≤ %0.05<br>• False Rejection Rate (FRR) ≤ %0.05<br>• Equal Error Rate (EER) ≤ %0.1<br>• Ortalama işlem süresi ≤ 2 saniye<br>• System Usability Scale (SUS) skoru ≥ 80/100<br>• Kullanıcı memnuniyet anketi (5'li Likert) ≥ 4.2 | • Proje ilerleme raporları (aylık)<br>• Teknik test raporları ve log kayıtları<br>• Model performans metrikleri (confusion matrix, ROC curve)<br>• Kullanıcı test sonuçları ve anket verileri<br>• Danışman değerlendirme raporları<br>• Video demonstrasyon kayıtları | **Varsayımlar:**<br>• Proje ekibi tam kadro çalışır<br>• Donanım tedariki zamanında gerçekleşir<br>• Üniversite laboratuvar erişimi kesintisiz sağlanır<br>• Gönüllü katılımcı bulunur<br><br>**Riskler:**<br>• Ekip üyelerinin akademik yükümlülükleri proje süresini etkileyebilir<br>• NIR kamera tedarikinde gecikme olabilir |
| **Sonuçlar / Çıktılar (Outputs)**<br><br>**1.** NIR tabanlı avuç damar görüntüleme sistemi kuruldu<br><br>**2.** 500 görüntülük avuç damar veri seti oluşturuldu<br><br>**3.** Derin öğrenme tabanlı damar izi tanıma modeli geliştirildi<br><br>**4.** POS terminal ile entegre çalışan prototip sistem hazır<br><br>**5.** Güvenlik ve performans testleri tamamlandı<br><br>**6.** Bilimsel makale ve konferans sunumu hazırlandı | **Çıktı 1:**<br>• NIR kamera sistemi (850 nm, 1280x720) kuruldu<br>• Test görüntüleri başarıyla alındı (≥10 test)<br>• Sistem kalibrasyon dokümanı hazırlandı<br><br>**Çıktı 2:**<br>• 50 katılımcıdan 500 görüntü toplandı<br>• Veri seti metadata ile etiketlendi (%100)<br>• Etik kurul onayı alındı<br><br>**Çıktı 3:**<br>• CNN modeli eğitildi (≥100 epoch)<br>• Accuracy ≥%99, FAR ≤%0.05, FRR ≤%0.05<br>• Model dokümantasyonu hazırlandı<br><br>**Çıktı 4:**<br>• RESTful API çalışıyor (uptime ≥%99)<br>• POS entegrasyonu %100 tamamlandı<br>• İşlem süresi ≤2 saniye<br><br>**Çıktı 5:**<br>• 30 kullanıcı testi tamamlandı<br>• Spoofing tespit başarısı ≥%99.5<br>• Test raporu hazırlandı<br><br>**Çıktı 6:**<br>• Makale taslağı hazırlandı (≥6000 kelime)<br>• Konferans özeti gönderildi | • Donanım fatura ve kurulum fotoğrafları<br>• Veri seti kayıt defteri<br>• Etik kurul onay belgesi<br>• Katılımcı onam formları<br>• Model eğitim log dosyaları<br>• GitHub repository<br>• API dokümantasyonu<br>• Test senaryoları ve sonuç raporları<br>• Performans grafikleri<br>• Kullanıcı anket formları<br>• Video demonstrasyon<br>• Makale ve sunum dosyaları | **Varsayımlar:**<br>• Teknik altyapı beklenen özelliklerde çalışır<br>• Katılımcılar veri toplama sürecine istekli katılır<br>• Derin öğrenme modeli hedeflenen performansa ulaşır<br><br>**Riskler:**<br>• Görüntü kalitesi beklenenin altında olabilir<br>• Model eğitiminde overfitting sorunu yaşanabilir<br>• POS entegrasyonunda uyumsuzluk çıkabilir<br>• Kullanıcı test sonuçları hedefin altında kalabilir |
| **Faaliyetler (Activities)**<br><br>**1.** Literatür taraması ve sistem tasarımı<br><br>**2.** NIR kamera, POS terminal ve bilgisayar donanımı temini<br><br>**3.** Donanım kurulumu ve kalibrasyon<br><br>**4.** Etik kurul başvurusu ve onay süreci<br><br>**5.** Gönüllü katılımcılardan avuç damar görüntüsü toplama<br><br>**6.** Görüntü ön işleme (ROI tespiti, segmentasyon, kontrast iyileştirme)<br><br>**7.** Derin öğrenme modeli tasarımı ve eğitimi<br><br>**8.** Hiperparametre optimizasyonu ve model iyileştirme<br><br>**9.** POS terminal entegrasyon yazılımı geliştirme<br><br>**10.** RESTful API ve veri tabanı oluşturma<br><br>**11.** Kullanıcı arayüzü tasarımı<br><br>**12.** Canlılık testi (liveness detection) algoritması entegrasyonu<br><br>**13.** Güvenlik testleri (penetrasyon, spoofing)<br><br>**14.** Kullanıcı testleri ve anket uygulaması<br><br>**15.** Performans metrikleri ölçümü ve analizi<br><br>**16.** Nihai rapor ve makale yazımı<br><br>**17.** Konferans sunumu hazırlığı | **Girdiler (Inputs)**<br><br>**İnsan Kaynakları:**<br>• Proje yürütücüsü (1 kişi) – koordinasyon<br>• Donanım uzmanı (1 kişi) – NIR sistem kurulumu<br>• Elektronik entegrasyon uzmanı (1 kişi) – POS entegrasyonu<br>• Yazılım geliştirici (1 kişi) – AI/ML modeli<br>• Danışman öğretim üyesi – metodoloji rehberliği<br><br>**Malzemeler:**<br>• NIR kamera modülü (850 nm)<br>• NIR LED ışık kaynağı<br>• POS terminal test cihazı<br>• Yüksek performanslı bilgisayar (GPU)<br>• Elektronik komponentler (Arduino, sensörler, kablolar)<br>• Tripod ve tutacak aparatları<br><br>**Yazılım ve Hizmetler:**<br>• Python, OpenCV, TensorFlow/PyTorch<br>• Bulut bilişim servisi (AWS/Google Cloud)<br>• MATLAB/SPSS lisansları<br>• Etik kurul başvuru ücreti<br>• Makale editörleme hizmeti<br><br>**Altyapı:**<br>• Üniversite laboratuvarı<br>• İnternet ve elektrik altyapısı<br>• Toplantı ve test alanları | **Maliyetler (Costs)**<br><br>**Toplam Bütçe: 64.500 TL**<br><br>• 35.000 TL – Bilgisayar (GPU)<br>• 8.000 TL – NIR kamera<br>• 5.000 TL – POS terminal<br>• 4.000 TL – LED ışık sistemi<br>• 1.500 TL – Elektronik komponentler<br>• 800 TL – Tripod ve aparatlar<br>• 700 TL – Baskı malzemeleri<br>• 3.000 TL – Bulut servisi<br>• 3.000 TL – Yazılım lisansları<br>• 1.500 TL – Dil editörleme<br>• 500 TL – Etik kurul<br>• 1.500 TL – Ulaşım<br><br>**Zaman:**<br>• 6 ay proje süresi<br>• Haftalık ortalama 15-20 saat/kişi<br>• Toplam ~480 kişi-saat | **Önkoşullar (Preconditions):**<br>• Proje bütçesi onaylanmış ve kullanıma hazır<br>• Üniversite laboratuvar erişim izni alınmış<br>• Danışman öğretim üyesi atanmış<br>• Proje ekibi tam kadro oluşturulmuş<br><br>**Varsayımlar:**<br>• Finansman kesintisiz sağlanır<br>• Proje ekibi sağlık sorunları yaşamaz<br>• Üniversite altyapısı kesintisiz kullanılabilir<br>• Tedarikçiler zamanında teslimat yapar<br><br>**Riskler:**<br>• Bütçe yetersiz kalabilir (malzeme fiyat artışları)<br>• Donanım arızalanabilir<br>• Elektrik kesintileri yaşanabilir<br>• Pandemi/salgın süreci katılımcı toplama sürecini etkileyebilir<br>• Ekip üyesi projeyi bırakabilir |

---

## Mantıksal Çerçeve Matrisi Kullanım Notları:

### 📊 Müdahale Hiyerarşisi (Dikey Mantık):
Projede **"neden-sonuç"** ilişkisi vardır:
- **Faaliyetler** → **Çıktıları** üretir
- **Çıktılar** → **Proje Amacını** gerçekleştirir
- **Proje Amacı** → **Genel Amaca** katkı sağlar

### 📈 Performans İzleme (Yatay Mantık):
Her seviyede:
- **Ne başarılacak?** (Müdahale Mantığı)
- **Nasıl ölçülecek?** (Göstergeler)
- **Nereden doğrulanacak?** (Doğrulama Kaynakları)
- **Hangi koşullar gerekli?** (Varsayımlar/Riskler)

### ⚠️ Risk Yönetimi:
- **Önkoşullar:** Projenin başlaması için mutlaka gerekli
- **Varsayımlar:** Gerçekleşmesi beklenen, kontrol dışı faktörler
- **Riskler:** Projeyi tehdit edebilecek olaylar (B planı gerektirir)

### 🎯 Gösterge Özellikleri (SMART):
- **S**pecific (Spesifik): FAR ≤%0.05
- **M**easurable (Ölçülebilir): Sayısal değerler
- **A**chievable (Ulaşılabilir): Gerçekçi hedefler
- **R**elevant (İlgili): Proje amacına uygun
- **T**ime-bound (Zamana bağlı): 6 ay içinde

---

## Proje Döngüsü Yönetimi İzleme Takvimi:

| Ay | İzlenecek Çıktılar | Sorumlu | Doğrulama Yöntemi |
|---|---|---|---|
| **1. Ay** | • Sistem tasarımı tamamlandı mı?<br>• Donanım siparişleri verildi mi? | Proje Yürütücüsü | Tasarım dokümanı kontrolü<br>Sipariş faturaları |
| **2. Ay** | • NIR kamera kuruldu mu?<br>• Etik kurul onayı alındı mı? | Donanım Uzmanı<br>Proje Yürütücüsü | Test görüntüleri<br>Onay belgesi |
| **3. Ay** | • Veri toplama %50 tamamlandı mı?<br>• Ön işleme algoritmaları çalışıyor mu? | Tüm Ekip | Veri seti kayıt defteri<br>Kod test sonuçları |
| **4. Ay** | • Model eğitimi tamamlandı mı?<br>• Performans metrikleri hedefte mi? | Yazılım Geliştirici | Model değerlendirme raporu<br>Accuracy, FAR, FRR değerleri |
| **5. Ay** | • POS entegrasyonu çalışıyor mu?<br>• Kullanıcı testleri başladı mı? | Entegrasyon Uzmanı<br>Proje Yürütücüsü | Demo video<br>Test katılımcı listesi |
| **6. Ay** | • Tüm testler tamamlandı mı?<br>• Rapor ve makale hazır mı? | Tüm Ekip | Nihai rapor<br>Makale taslağı |

---

**Son Güncelleme:** [Tarih]  
**Hazırlayan:** [Proje Ekibi]  
**Onaylayan:** [Danışman Adı]