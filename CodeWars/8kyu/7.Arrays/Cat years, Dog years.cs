// https://www.codewars.com/kata/5a6663e9fd56cb5ab800008b/train/csharp
public class Dinglemouse {
    public static int[] humanYearsCatYearsDogYears(int humanYears) {
        int cat = 0, dog = 0;
        for (int i = 1; i <= humanYears; i++) {
            if (i == 1) {
                cat += 15;
                dog += 15;
            }
            if (i == 2) {
                cat += 9;
                dog += 9;
            }
            if (i > 2) {
                cat += 4;
                dog += 5;
            }
        }
        return new int[]{humanYears, cat, dog};
    }
}
//
public class Dinglemouse {
    public static int[] humanYearsCatYearsDogYears(int humanYears) {
        
        int catYear = 15 + (humanYears >= 2 ? 9 + 4 * (humanYears-2): 0);
        int dogYear = 15 + (humanYears >= 2 ? 9 + 5 * (humanYears-2): 0);
    
        return new int[]{humanYears,catYear ,dogYear};
    }
}
