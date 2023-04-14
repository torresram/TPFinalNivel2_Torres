select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, M.Descripcion Marca, C.Descripcion Categoria, A.ImagenUrl, A.Precio
from ARTICULOS A, MARCAS M, CATEGORIAS C
where A.IdMarca = M.Id and A.IdCategoria = C.Id


select Id, Descripcion from MARCAS
select Id, Descripcion from CATEGORIAS
select * from ARTICULOS

Insert into ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio)
values ('','','',2,1,'',120.020)

update ARTICULOS set Codigo = '123', Nombre = 'Nokia 1100', Descripcion = 'Clasicon', IdMarca = 3, IdCategoria = 1, ImagenUrl = 'https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.amazon.es%2FNokia-Tel%25C3%25A9fono-m%25C3%25B3vil-1100-monocromo%2Fdp%2FB0000UI2WI&psig=AOvVaw14VBpqm61kPxGQA-QjtWLK&ust=1679940342623000&source=images&cd=vfe&ved=0CBAQjRxqFwoTCKD7otCX-v0CFQAAAAAdAAAAABAE', Precio = 156.263
where Id = 6

insert into MARCAS (Descripcion) values ('Nokia')
insert into CATEGORIAS (Descripcion) values ('Consoladores')

delete from MARCAS where Id = 6
delete from CATEGORIAS where Id = 6

select Codigo from ARTICULOS
select Descripcion from CATEGORIAS
select Descripcion from MARCAS