using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace FirstEF.Cars;
[Table(nameof(Car))]
internal class Car
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Model { get; set; } = null!;
    public int HorsePower { get; set; }
}
