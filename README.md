# Transportation

## Uygulamanın yaptığı işlevler
1.Kullanıcılar sisteme kayıt olup üyelik girişi yapabiliyor. <br>
2-Kullanıcılar nakliye talebi oluşturup nakliye işlemini yapacak şirketin onayını bekler. <br>
3-Nakliye talebini Admin role üzerinden kurguladım.Admin talebi onaylar.<br>
4-Talep onaylandıktan sonra onaylanan talep listesinden bu isteği görür. <br>
5-Listede yaptığı talepleri görür.Yapılan taleplerle alakalı taşıyıcıya mesaj gönderip rezervasyon oluşturabilir.<br>
6-Rezervasyon oluştururken araç,sürücü,taşıma ekibi bilgilerini görüp rezervasyon oluşturabilir.<br>
7-Admin kullanıcısı gelen mesajları cevaplar ve kullanıcıyla mesajlaşma etkileşimi oluşturulur.<br>
8-Admin kullanıcısı onaylı taleplerden taşıma işlemi bitince taşıma işlemini tamamlaya basar ve işlem tamamlanır.<br>
9-İşlemi tamamnlanan kullanıcı tamamlanan işlemlerde işlemini görür ve onunla alakalı değerlendirmesini yapar.<br>
10-Yapılan değerlendirmeler rezervasyon oluştururken gözükür.<br>



### Uygulama seed dataları Repository-Config dosyaları içinde yer almaktadır.
### Admin kullanıcı bilgileri de UI-Infrastructure-Extension-ApplicationExtensions yolu takip edilerek ConfigureDefaultAdminUser methodunda yazılıdır.
