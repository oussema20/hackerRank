    public static void plusMinus(List<int> arr)
    {

        int arrLenght = arr.Count();
        int positivesCount = arr.Where(x => x > 0).Count();
        int negativesCount = arr.Where(x => x < 0).Count();
        int zerosCount = arr.Where(x => x == 0).Count();
        
      
        Console.WriteLine(((double)positivesCount/arrLenght).ToString("N6"));
        Console.WriteLine(((double)negativesCount/arrLenght).ToString("N6"));
        Console.WriteLine(((double)zerosCount/arrLenght).ToString("N6"));

    }