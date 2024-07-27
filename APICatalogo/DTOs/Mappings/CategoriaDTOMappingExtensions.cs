using APICatalogo.Models;

namespace APICatalogo.DTOs.Mappings
{
    public static class CategoriaDTOMappingExtensions
    {
        public static CategoriaDTO? ToCategoriaDTO(this Categoria categoria)
        {
            if (categoria is null)
                return null;

            return new CategoriaDTO
            {
                CategoriaId = categoria.CategoriaId,
                Nome = categoria.Nome,
                ImagemUrl = categoria.ImagemUrl
            };
        }

        public static Categoria? ToCategoria(this CategoriaDTO categoriaDTO)
        {
            if (categoriaDTO is null) return null;

            return new Categoria
            {
                CategoriaId = categoriaDTO.CategoriaId,
                Nome = categoriaDTO.Nome,
                ImagemUrl = categoriaDTO.ImagemUrl
            };
        }
        public static IEnumerable<CategoriaDTO> ToCategoriasDTOList(this IEnumerable<Categoria> categoria)
        {
            if (categoria is null || !categoria.Any()) //verificar se a lista de categorias não contem nenhum elemento
            {
                return new List<CategoriaDTO>();
            }
            return categoria.Select(categoria => new CategoriaDTO //projetar cada objeto categorias em um novo no CategoriasDTO
            {
                CategoriaId = categoria.CategoriaId,
                Nome = categoria.Nome,
                ImagemUrl = categoria.ImagemUrl
            }).ToList();
        }
    }
}
