--Select yorum satırı  * klon anlama geliyor
--Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers; ContactName Adi diye gösterir böyle yazarsak
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers;

SELECT * FROM Customers WHERE City='Berlin'

select * FROM Products WHERE CategoryID=1 or CategoryID=3

--    CategoryID<> eşit olmayan demek.
select * FROM Products WHERE CategoryID=1 and UnitPrice>=10 

-- order by sırala demek küçükten büyüğe default arayı bu(asc )
select * from Products order by CategoryID,ProductName --Önce CategoryID sırala sonra CategoryID 1,2,3...leri arasında ProductName sırala

--asc=ascending(yükselen)
--desc= descending (azalan)
select * from Products where CategoryID=1 order by UnitPrice desc --eticaret sitelerinde arttırma azaltma filresi kullanırkenki kısım burası

select count(*) Adet from Products

--yönetim dedi hangi kategoride kaç farklı ürünümüz var? CategoryID=1 kaç tane urun varsa onu yaz, CategoryID=2 kaç tane varsa onu yaz ....

select CategoryID from Products order by CategoryID --boyle yazarsan 1,2,3...'den kaç tane varsa hepsini tek tek yazar.

select CategoryID from Products group by CategoryID -- group bylerda SELECT edilen kolan sadece ve sadece group byda yazdığımız alan olabilir. Veya kümülatif data count(*) gibi olabilir.

--cevap bu
select  CategoryID ,count(*) UrunAdetSayisi from Products group by CategoryID

select  CategoryID ,count(*) UrunAdetSayisi from Products where UnitPrice>20 group by CategoryID having count(*)<10
--having kümülatif dataya yani count(*) kısmına koşul yazabilmemizi sağlar.
--select * from Products where UnitPrice>20 order by CategoryID 


select*from Products
select*from Categories
--products ile Categories'lerin birleşimden veri getirmek istiyoruz. on kısmına koşulu yazıyoruz.
select Products.CategoryID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories 
on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10 
order by Products.UnitPrice 

--tablo ismibde boşluk olduğu için [Order Details] var.
--inner join iki tabloda da eşleşenleri getirir. Eşleşmeyen dataları getirmez.
--left join solda olup sağda olmayanlarıda getir demek.(yani Productsda olup Order Detailsda olmayanları da getir. )

select * from Products p left join [Order Details] od 
on p.ProductID=od.ProductID
inner join Orders o
on o.OrderID=od.OrderID   --2den fazla tablo eklemek için yine inner join yazdık. Orders tablosunu ekledik. 

select * from customers c inner join Orders o 
on c.CustomerID=o.CustomerID
where o.CustomerID is null  --Müsterimiz olup sipariş vermeyenleri böyle bulabiliriz.


select* from Customers order by CustomerID
select* from Orders order by CustomerID
