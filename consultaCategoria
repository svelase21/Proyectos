SELECT
    c.Nombre AS NombreCategoria,
    p.Nombreproducto AS NombreProducto,
    v.Fecha AS FechaVenta
FROM
    Venta v
JOIN Producto p ON
    v.Codigoproducto = p.Codigoproducto
JOIN Categoria c ON
    p.Codigocategoria = c.Codigocategoria
ORDER BY
    v.Fecha
DESC
LIMIT 1;
