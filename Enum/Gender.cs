using System.ComponentModel;

namespace DIO.Series
{
  public enum Gender
  {
   [Description("Ação")]
    Action = 1,

   [Description("Aventura")]
    Adventure = 2,

   [Description("Comédia")]
    Comedy = 3,

   [Description("Documentário")]
    Documentary = 4,

   [Description("Drama")]
    Drama = 5,

   [Description("Espionagem")]
    Espionage = 6,

   [Description("Faroeste")]
    Western = 7,

   [Description("Fantasia")]
    Fantasy = 8,

   [Description("Ficção Cientifíca")]
    ScientificFiction = 9,

   [Description("Musical")]
    Musical = 10,

   [Description("Romance")]
    Novel = 11,

   [Description("Suspense")]
    Thriller = 12,

   [Description("Terror")]
    Terror = 13,
  }
}