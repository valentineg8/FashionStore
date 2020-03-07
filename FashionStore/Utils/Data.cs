using System;
using System.Collections.Generic;
using FashionStore.Models;

namespace FashionStore.Utils
{
    public static class Data
    {
        public static List<Product> Products = new List<Product>
        {

            new Product
            {
                Id = 1,
                Name = "Ameowica",
                Photo = "https://vangogh.teespring.com/v3/image/EZP5X7Ts0ZjTYEuVCJf7atgh3Og/480/560.jpg",
                Rating = 4.8,
                Size = "L",
                Price = "$24.99",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                IsFavorite = true,
                Category = Category.Tshirt
            },
            new Product
            {
                Id = 2,
                Rating = 4.4,
                Name = "AA BATTERY FUNNY TSHIRT",
                Size = "M",
                Photo = "https://vangogh.teespring.com/v3/image/kpGLWhvOtR0xogt24XJRhT7S-mw/480/560.jpg",
                Price = "$28.99",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                IsFavorite = false,
                Category = Category.Tshirt

            },

            new Product
            {
                Id = 9,
                Rating = 4.3,
                Name = "Women's Hoodie Dress",
                Size = "S",
                Photo = "https://www.prodirectselect.com/productimages/V3_1_Main/V3_1_Main_0349904.jpg",
                Price = "$39.99",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                IsFavorite = false,
                Category = Category.Hoodies
            },
            new Product
            {
                Id = 10,
                Rating = 3.3,
                Name = "Unisex Crewneck Sweatshirt",
                Size = "S",
                Photo = "https://images-na.ssl-images-amazon.com/images/I/61gBXX5N-tL._AC_UY550_.jpg",
                Price = "$34.99",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                IsFavorite = true,
                Category = Category.Hoodies
            },
            new Product
            {
                Id = 3,
                Rating = 4.5,
                Name = "Save the Amazon",
                Size = "L",
                Photo = "https://vangogh.teespring.com/v3/image/nIICjb8m1X3RHfIW2Qz8FVXBY1s/480/560.jpg",
                Price = "$19.99",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                IsFavorite = false,
                Category = Category.Tshirt

            },
            new Product
            {
                Id = 4,
                Rating = 4.3,
                Name = "Inhale. Exhale Scottie",
                Size = "L",
                Photo = "https://vangogh.teespring.com/v3/image/oPyLqRosQFMoqcWpJEq2VSvC7xM/480/560.jpg",
                Price = "$19.99",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                IsFavorite = false,
                Category = Category.Tshirt

            },
            new Product
            {
                Id = 5,
                Rating = 5,
                Name = "Save the Amazon Rainforest",
                Size = "L",
                Photo = "https://vangogh.teespring.com/v3/image/rlg7BaMN05Hbr1JDdFQMonxPSW4/480/560.jpg",
                Price = "$29.99",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                IsFavorite = false,
                Category = Category.Hoodies

            },
            new Product
            {
                Id = 6,
                Rating = 5,
                Name = "NOPE",
                Size = "L",
                Photo = "https://vangogh.teespring.com/v3/image/N8r28I0QHA_8pYK5Y_WGBSSzwiU/480/560.jpg",
                Price = "$29.99",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                IsFavorite = false,
                Category = Category.Tshirt

            },
            new Product
            {
                Id = 7,
                Rating = 4.7,
                Name = "Women's Scoop-Neck T-Shirt",
                Size = "M",
                Photo = "https://pimg.bucklecontent.com/images/products/55460BCRM1025/CAS/f/338ec076bfdf2216aed02b42d337747fv3?cropH=1880&cropW=1603&quality=0.8&width=1425",
                Price = "$19.99",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                IsFavorite = true,
                Category = Category.Tshirt

            },
            new Product
            {
                Id = 8,
                Rating = 4.3,
                Name = "Unisex Shawl Collar Hoodie",
                Size = "S",
                Photo = "https://www.belovedshirts.com/wp-content/uploads/2019/11/ArtworkName_Hoodie_Beloved_F-1.jpg",
                Price = "$49.99",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                IsFavorite = false,
                Category = Category.Hoodies
            },
            new Product
            {
                Id = 11,
                Rating = 4.5,
                Name = "Letter Embroidery Flap Pocket Pants",
                Size = "L",
                Photo = "https://gloimg.zafcdn.com/zaful/pdm-product-pic/Clothing/2019/10/10/goods-first-img/1572408795439798479.jpg",
                Price = "$25.00",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                IsFavorite = false,
                Category = Category.Pants
            },
            new Product
            {
                Id = 12,
                Rating = 4.1,
                Name = "Tribal Ditsy Patchwork Print Pants",
                Size = "L",
                Photo = "https://gloimg.zafcdn.com/zaful/pdm-product-pic/Clothing/2019/11/21/goods-first-img/1574891113592208637.jpg",
                Price = "$17.17",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                IsFavorite = false,
                Category = Category.Pants
            },
            new Product
            {
                Id = 13,
                Rating = 4.1,
                Name = "Graphic Pattern Drawstring Pants",
                Size = "S",
                Photo = "https://gloimg.zafcdn.com/zaful/pdm-product-pic/Clothing/2020/01/14/goods-first-img/1582141588521339591.jpg",
                Price = "$24.03",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                IsFavorite = true,
                Category = Category.Pants
            },
            new Product
            {
                Id = 14,
                Rating = 4.1,
                Name = "Pocket Decoration Pants",
                Size = "M",
                Photo = "https://gloimg.zafcdn.com/zaful/pdm-product-pic/Clothing/2019/11/11/goods-first-img/1573618887042197707.jpg",
                Price = "$18.03",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                IsFavorite = false,
                Category = Category.Pants
            }
        };
    }
}
