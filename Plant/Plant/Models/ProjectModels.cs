using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Plant.Models
{

    #region Plant
    public class Plant //Основной класс растения
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string NameRu { get; set; }//Имя растение
        [MaxLength(20)]
        public string NamEn { get; set; }
        [Required]
        [MaxLength(20)]
        public string BotanicalName { get; set; }//Его ботаническое название
        [Required]
        [Column(TypeName = "text")]
        public string DescriptionRu { get; set; }//Описание растения в хтмл формате
        [Column(TypeName = "text")]
        public string DescriptioEen { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string TransplantRu { get; set; }//Частота и особенности пересадки
        [Column(TypeName = "text")]
        public string TransplantEn { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string PossibleProblemsRu { get; set; }//Возможные проблемы с растением
        [Column(TypeName = "text")]
        public string PossibleProblemsEn { get; set; }
        [Required]
        [MaxLength(100)]
        public string WikiUrlRu { get; set; }//Ссылка на вики с растением
        [MaxLength(100)]
        public string WikiUrlEn { get; set; }
        [Required]
        [MaxLength(20)]
        public string GrowthDurationRu { get; set; }//ALLOW NULL Длительность выращивания доо максимального роста
        [MaxLength(20)]
        public string GrowthDurationEn { get; set; }
        public int? MinHeightRu { get; set; }//максимальная величина растения в см
        public int? MinHeightEn { get; set; }//максимальная величина растения в футах
        public int? MaxHeightRu { get; set; }//максимальная величина растения в см
        public int? MaxHeightEn { get; set; }//максимальная величина растения в футах
        public int? MinTemperature { get; set; }//ALLOW NULL минимальная температура цельсий
        public int? MaxTemperature { get; set; }//ALLOW NULL максимальная температура цельсий
        public int? Rating { get; set; }//рейтинг
        public int? Views { get; set; }//просмотры
        public int? CommentNumber { get; set; }//кол-во комментов, менять при добавлении нового коммента
        public DateTime? Time { get; set; }//время добавления
        [Required]
        [MaxLength(100)]
        public string PictureUrl { get; set; }//ссылка лицевой картинки растения
        public float? AveragePriceRub { get; set; }//средняя цена растения
        public float? AveragePriceGrn { get; set; }//средняя цена растения
        public float? AveragePriceEuro { get; set; }//средняя цена растения
        public float? AveragePriceDollar { get; set; }//средняя цена растения




        //public virtual ICollection<Picture> Pictures { get; set; }//ссылка на все картинки с этим растением, первые 6 которые добавляются нами, а остальные юзерами, которые пользуются определителем растений(если правильно определило, то он тыкает ПРАВИЛЬНО и фотка добавляется ко всем картинкам)

        public int? LeafId { get; set; }
        public virtual Leaf Leaf { get; set; }//ALLOW NULL ссылка на лист



        //[ForeignKey("PlantGrowDifficulty")]
        //public int PlantGrowDifficulty_Id { get; set; }
        //public virtual PlantGrowDifficulty PlantGrowDifficulty { get; set; }//ссылка на таблицу сложности выращивания растения
        //[ForeignKey("PlantWaterDemand")]
        //public int PlantWaterDemand_Id { get; set; }
        //public virtual PlantWaterDemand PlantWaterDemand { get; set; }//ссылка на таблицу потребности растения в воде
        //public virtual ICollection<PlantSunDemand> PlantSunDemands { get; set; }//ссылка на таблицу потребности растения в солнце
        //[ForeignKey("PlantHeightType")]
        //public int PlantHeightType_Id { get; set; }
        //public virtual PlantHeightType PlantHeightType { get; set; }//ссылка на таблицу типа высоты растения
        //[ForeignKey("PlantGrowSpeed")]
        //public int PlantGrowSpeed_Id { get; set; }
        //public virtual PlantGrowSpeed PlantGrowSpeed { get; set; }//ссылка на таблицу типа скорости роста растения
        //public virtual ICollection<PlantGrowType> PlantGrowTypes { get; set; }//ссылка на таблицу типа развития роста растения
        //public virtual ICollection<PlantPlaceGrow> PlantPlaceGrows { get; set; }//ссылка на таблицу места для растения
        //public virtual ICollection<PlantFeature> PlantFeatures { get; set; }//ALLOW NULL ссылка на таблицу особенностей растения
        //public virtual Fruit Fruit { get; set; }//ALLOW NULL ссылка на таблицу с плодом
        //public virtual PlantStem PlantStem { get; set; }//ALLOW NULL ссылка на таблицу с стеблем
        //public virtual Flower Flower { get; set; }//ALLOW NULL ссылка на таблицу с цветком
        //public virtual ICollection<Post> Posts { get; set; }//ALLOW NULL ссылка на таблицу с постом из блога
        //public virtual ICollection<User> Users { get; set; }//ссылка на таблицу с пользователями если пользователь не админ, то следует рассматривать все связи с растениями как "Желаемое", тоесть то что юзеры добавляют в список желаемого
        //public virtual ICollection<Comment> Comments { get; set; }//ALLOW NULL ссылка на таблицу с комментами
        //[ForeignKey("PlantFamily")]
        //public int PlantFamily_Id { get; set; }
        //public virtual PlantFamily PlantFamily { get; set; }//ссылка на таблицу с Семейством растения
        //[ForeignKey("PlantGenus")]
        //public int PlantGenus_Id { get; set; }
        //public virtual PlantGenus PlantGenus { get; set; }//ссылка на таблицу с Родом растения
        //public virtual ICollection<Price> Prices { get; set; }//ALLOW NULL ссылка на таблицу с ценами
        //public virtual ICollection<UserWish> UserWishes { get; set; }//ALLOW NULL
        //public virtual ICollection<UserHave> UserHaves { get; set; }//ALLOW NULL
        //[ForeignKey("AirHumIdity")]
        //public int AirHumIdity_Id { get; set; }
        //public virtual AirHumIdity AirHumIdity { get; set; }//влажность воздуха

    }
    #endregion
    
    #region Leaf
    public class Leaf//Лист
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string PictureUrl { get; set; }//ссылка лицевой картинки
        [MaxLength(100)]
        public string CompoundLeafUrl { get; set; }//ALLOW NULL ссылка лицевой картинки сложного листа, если он сложный

        public int? LeafThicknessId { get; set; }
        public virtual LeafThickness LeafThickness { get; set; }//allow null если иголка, ссылка на таблицу с толщиной листа
        public virtual ICollection<LeafColor> LeafColors { get; set; }//allow null если иголка,ссылка на таблицу с цветом листа
        public int? LeafLocationId { get; set; }
        public virtual LeafLocation LeafLocation { get; set; }//allow null если иголка,ссылка на таблицу с нахождением листа на стебле
        public int? LeafConnectionId { get; set; }
        public virtual LeafConnection LeafConnection { get; set; }//allow null если иголка,ссылка на таблицу с типом присоединения листа к стеблю
        public int? LeafVenationId { get; set; }
        public virtual LeafVenation LeafVenation { get; set; }//allow null если иголка,ссылка на таблицу с жилкованием листа

        public int? LeafShapeId { get; set; }
        public virtual LeafShape LeafShape { get; set; }//ссылка на таблицу с формой листа
        public int? LeafMarginId { get; set; }
        public virtual LeafMargin LeafMargin { get; set; }//allow null если иголка,ссылка на таблицу с типом края листа
        //public virtual ICollection<Picture> Pictures { get; set; }//ссылка на таблицу с картинками
        public virtual ICollection<Plant> Plants { get; set; }//ссылка на таблицу с растением
    }
    #endregion

    #region LeafColor
    public class LeafColor//цвет листа, добавляются по мере добавления листа
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string NameRu { get; set; }//название цвета
        [Required]
        [MaxLength(20)]
        public string NameEn { get; set; }
        [Required]
        [MaxLength(100)]
        public string PictureUrl { get; set; }//ссылка на картинку с цветом

        public virtual ICollection<Leaf> Leafs { get; set; }//ссылка на картинку с листом
    }
    #endregion

    #region LeafThickness
    public class LeafThickness//толщина листа:толстый и тонкий
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string NameRu { get; set; }//Название толщины
        [Required]
        [MaxLength(20)]
        public string NameEn { get; set; }
        [Required]
        [MaxLength(100)]
        public string PictureUrl { get; set; }//ссылка на картинку

        public virtual ICollection<Leaf> Leafs { get; set; }//ссылка на таблицу с листом
    }
    #endregion

    #region LeafShape
    public class LeafShape//таблица формы листа: добавлять по мере добавления листа, иголки тоже входят сюда, вот примеры: http://trifoly.ru/2011/09/osnovnye-formy-listev/ и http://www.floriculture.ru/rast/razn/morf/list.shtml
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string NameRu { get; set; }//Название формы
        [Required]
        [MaxLength(20)]
        public string NameEn { get; set; }
        [Required]
        [MaxLength(100)]
        public string PictureUrl { get; set; }//ссылка на картинку с формой листа

        public virtual ICollection<Leaf> Leafs { get; set; }//ссылка на таблицу с листом
    }
    #endregion

    #region LeafMargin
    public class LeafMargin//таблица с типами края листа 
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string NameRu { get; set; }//Название типа
        [Required]
        [MaxLength(20)]
        public string NameEn { get; set; }
        [Required]
        [MaxLength(100)]
        public string PictureUrl { get; set; }//ссылка на картинку с формой листа

        public virtual ICollection<Leaf> Leafs { get; set; }//ссылка на таблицу с листом
    }
    #endregion
    
    #region LeafLocation
    public class LeafLocation//место нахождения листа на стебле: три типа http://beaplanet.ru/listya_rasteniy/raspolozhenie_listev.html 
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string NameRu { get; set; }//Название типа
        [Required]
        [MaxLength(20)]
        public string NameEn { get; set; }
        [Required]
        [MaxLength(100)]
        public string PictureUrl { get; set; }//ссылка на картинку типа

        public virtual ICollection<Leaf> Leafs { get; set; }//ссылка на таблицу с листом
    }
    #endregion

    #region LeafConnection
    public class LeafConnection//тип присоединения листа к стеблю: собраны на верхушке(пальчаторасположенны) стебляleaf connection http://plant-Id.novenyhatarozo.info/Identifier#15.51.decurrent;15.52.basal
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string NameRu { get; set; }//название типа
        [Required]
        [MaxLength(20)]
        public string NameEn { get; set; }
        [Required]
        [MaxLength(100)]
        public string PictureUrl { get; set; }//ссылка на картинку типа

        public virtual ICollection<Leaf> Leafs { get; set; }
    }
    #endregion

    #region LeafVenation
    public class LeafVenation//типы жилкования листа: http://www.floriculture.ru/rast/razn/morf/jilki.shtml
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string NameRu { get; set; }//название типа
        [Required]
        [MaxLength(20)]
        public string NameEn { get; set; }
        [Required]
        [MaxLength(100)]
        public string PictureUrl { get; set; }//ссылка на картинку типа

        public virtual ICollection<Leaf> Leafs { get; set; }//ссылка на таблицу с листом
    }
    #endregion

    #region picture
    //public class Picture//таблица с картинками, если добавил админ, то Checked сразу TRUE
    //{
    //    public int Id { get; set; }
    //    [Required]
    //    [MaxLength(100)]
    //    public string PictureUrl { get; set; }//ссылка на картинку
    //    public DateTime Time { get; set; }//Время загрузки картинки
    //    public bool Checked { get; set; }//после загрузки юзером нужно проверить что он загрузил
    //    [Column(TypeName = "text")]
    //    public string Comment_ru { get; set; }
    //    [Column(TypeName = "text")]
    //    public string Comment_en { get; set; }

    //    public virtual FlowerColor FlowerColor { get; set; }//ALLOW NULL Чтоб при поиске красных цветков показывались красные цветы в поиске
    //    [ForeignKey("User")]
    //    public int User_Id { get; set; }
    //    public virtual User User { get; set; }//ссылка на таблицу с пользователем, который добавил ее
    //    public virtual Comment Comment { get; set; }//ALLOW NULL ссылка на таблицу с комментарием
    //    public virtual Post Post { get; set; }//ALLOW NULL ссылка на таблицу с постом
    //    public virtual Fruit Fruit { get; set; }//ALLOW NULL ссылка на таблицу с плодом
    //    public virtual Leaf Leaf { get; set; }//ALLOW NULL ссылка на таблицу с листом
    //    public virtual Plant Plant { get; set; }//ALLOW NULL ссылка на таблицу с растением
    //    public virtual Flower Flower { get; set; }//ALLOW NULL ссылка на таблицу с цветком
    //    public virtual PlantStem PlantStem { get; set; }//ALLOW NULL ссылка на таблицу с стеблем
    //    public virtual ItemCollection ItemCollection { get; set; }//ALLOW NULL ссылка на таблицу коллекцией картинок

    //}
    #endregion


   
}