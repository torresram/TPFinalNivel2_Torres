select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, M.Descripcion Marca, C.Descripcion Categoria, A.ImagenUrl, A.Precio
from ARTICULOS A, MARCAS M, CATEGORIAS C
where A.IdMarca = M.Id and A.IdCategoria = C.Id


select * from MARCAS
select * from CATEGORIAS
select * from ARTICULOS