//Array    Mar 01 2017

//values types資料型態(以int, char, double, float, string宣告)
//處理複雜事情:用array陣列，把相似的原始資料型態放到連續的位置，這種叫reference type(儲存的是reference的物件)
//宣告:先宣告reference variable，然後要create an object
//以int[] scores = new int[40]宣告，new int[40]即產生出物件


//若有40人，要算sum
for(int sum = 0, int i=0; i < 40; i++)
{
    sum = sum + scores[i];
    average = sum / 40;
}

//不用寫出長度: 用scores.Length
for(int sum = 0, int i=0; i < scores.Length; i++)
{
    sum = sum + scores[i];
    average = sum / scores.Length;
}

//練習參考(來自課本)
const int SIZE = 5;//宣告為常數
int[] lotteryNumbers = new int[SIZE];
Random rand = new Random();

for (int index = 0; index < lotteryNumbers.Length; index++)
{
    lotteryNumbers[index] = rand.Next(100);
}

firstLabel.Text = lotteryNumbers[0].ToString();


//array本來就是reg的，因此不用寫reg
//練習題目:全班45人

//for 輸入和輸出分開
//使用foreach來output
//foreach一般僅為輸出用，常用於array
