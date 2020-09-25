using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Cars
{
    public static class examples
    {
    //    var query =
    //from car in cars
    //group car by car.Manufacturer into carGroup
    //select new
    //{
    //    Name = carGroup.Key,
    //    Max = carGroup.Max(c => c.Combined),
    //    Min = carGroup.Min(c => c.Combined),
    //    Avg = carGroup.Average(c => c.Combined)
    //} into result
    //orderby result.Max descending
    //select result;



        //var query =
        //    from manufacturer in manufacturers
        //    join car in cars on manufacturer.Name equals car.Manufacturer
        //    into carGroup
        //   // orderby manufacturer.Name
        //    select new
        //    {
        //        Manufacturer = manufacturer,
        //        Cars = carGroup
        //    } into result
        //    group result by result.Manufacturer.Headquarters;


        //var query2 =
        //    manufacturers.GroupJoin(cars,       //inner sequence
        //    m => m.Name,                        //outer Key Selector
        //    c => c.Manufacturer,                //inner Key selector
        //    (m, g) => new                       //result selector
        //    {
        //        Manufacturer = m,
        //        Cars = g
        //    }).GroupBy(m => m.Manufacturer.Headquarters);

        public static void ExamplesHolder()
        {

            //var cars = ProcessFile("fuel.csv");
            //var manufacturers = ProcessManufacturers("manufacturers.csv");
            //var query2 =
            //    cars.GroupBy(c => c.Manufacturer)
            //    .Select(g =>
            //    {
            //        var results = g.Aggregate(new CarStatistics(),
            //                                    (acc, c) => acc.Accumulate(c),
            //                                    acc => acc.Compute());

            //        return new
            //        {
            //            Name = g.Key,
            //            Avg = results.Average,
            //            Min = results.Min,
            //            Max = results.Max
            //        };
            //    }).OrderByDescending(r => r.Max);


            //foreach (var result in query)
            //{
            //    Console.WriteLine($"{result.Name} ");
            //    Console.WriteLine($"\t Max: {result.Max}");
            //    Console.WriteLine($"\t Max: {result.Min}");
            //    Console.WriteLine($"\t Max: {result.Avg}");
            //}

            //var query = cars.Where(c => c.Manufacturer == "BMW" && c.Year == 2016)
            //    .OrderByDescending(c => c.Combined)
            //    .ThenBy(c => c.Name)
            //    .Select(c => c);

            //var query1 =
            //    from car in cars
            //    join manufacturer in manufacturers 
            //        on  new { car.Manufacturer, car.Year } 
            //        equals 
            //        new { Manufacturer = manufacturer.Name, manufacturer.Year }
            //    orderby car.Combined descending, car.Name ascending
            //    select new
            //    {
            //        car.Manufacturer,
            //        manufacturer.Headquarters,
            //        car.Name,
            //        car.Combined
            //    };

            //var query2 =
            //    cars.Join(manufacturers,
            //    c => new { c.Manufacturer, c.Year },
            //    m => new { Manufacturer = m.Name, m.Year },
            //    (c, m) => new
            //        {
            //            c.Manufacturer,
            //            c.Name,
            //            m.Headquarters,
            //            c.Combined
            //        })
            //    .OrderByDescending(c => c.Combined)
            //    .ThenBy(c => c.Name);


            //foreach (var car in query2.Take(10))
            //{
            //    Console.WriteLine($"{car.Manufacturer} : {car.Headquarters} : {car.Name} : {car.Combined}");
            //}

            //var top = cars
            //    .OrderByDescending(c => c.Combined)
            //    .ThenBy(c => c.Name)
            //    .Select(c => c)
            //    .First(c => c.Manufacturer == "BMW" && c.Year == 2016);


            //var result = cars.Any(c => c.Manufacturer == "Ford");

            //Console.WriteLine(result);

            //foreach (var car in query2.Take(10))
            //{
            //    Console.WriteLine($"{car.Manufacturer}  {car.Name} : {car.Combined}");
            //}

            //var result = cars.SelectMany(c => c.Name);

            //foreach (var name in result)
            //{
            //    Console.WriteLine(name);
            //}
        }
        //     var query2 =
        //cars.GroupBy(c => c.Manufacturer)
        //.Select(g =>
        //{
        //    var results = g.Aggregate(new CarStatistics(),
        //                                (acc, c) => acc.Accumulate(c),
        //                                acc => acc.Compute());

        //    return new
        //    {
        //        Name = g.Key,
        //        Avg = results.Average,
        //        Min = results.Min,
        //        Max = results.Max
        //    };
        //}).OrderByDescending(r => r.Max);


        //         foreach (var result in query)
        //         {
        //             Console.WriteLine($"{result.Name} ");
        //             Console.WriteLine($"\t Max: {result.Max}");
        //             Console.WriteLine($"\t Max: {result.Min}");
        //             Console.WriteLine($"\t Max: {result.Avg}");
        //         }

        //var query = cars.Where(c => c.Manufacturer == "BMW" && c.Year == 2016)
        //    .OrderByDescending(c => c.Combined)
        //    .ThenBy(c => c.Name)
        //    .Select(c => c);

        //var query1 =
        //    from car in cars
        //    join manufacturer in manufacturers 
        //        on  new { car.Manufacturer, car.Year } 
        //        equals 
        //        new { Manufacturer = manufacturer.Name, manufacturer.Year }
        //    orderby car.Combined descending, car.Name ascending
        //    select new
        //    {
        //        car.Manufacturer,
        //        manufacturer.Headquarters,
        //        car.Name,
        //        car.Combined
        //    };

        //var query2 =
        //    cars.Join(manufacturers,
        //    c => new { c.Manufacturer, c.Year },
        //    m => new { Manufacturer = m.Name, m.Year },
        //    (c, m) => new
        //        {
        //            c.Manufacturer,
        //            c.Name,
        //            m.Headquarters,
        //            c.Combined
        //        })
        //    .OrderByDescending(c => c.Combined)
        //    .ThenBy(c => c.Name);


        //foreach (var car in query2.Take(10))
        //{
        //    Console.WriteLine($"{car.Manufacturer} : {car.Headquarters} : {car.Name} : {car.Combined}");
        //}

        //var top = cars
        //    .OrderByDescending(c => c.Combined)
        //    .ThenBy(c => c.Name)
        //    .Select(c => c)
        //    .First(c => c.Manufacturer == "BMW" && c.Year == 2016);


        //var result = cars.Any(c => c.Manufacturer == "Ford");

        //Console.WriteLine(result);

        //foreach (var car in query2.Take(10))
        //{
        //    Console.WriteLine($"{car.Manufacturer}  {car.Name} : {car.Combined}");
        //}

        //var result = cars.SelectMany(c => c.Name);

        //foreach (var name in result)
        //{
        //    Console.WriteLine(name);

        //}
    }
}

