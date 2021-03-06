#include <iostream>
#include <iomanip>
#include <climits>
#include <cmath>
using namespace std;
int main() {
    int min1 = INT_MAX, min2 = INT_MAX, indexOfMin, N;
    cin>>N;
    int ar[N][2];//двумерный массив
    int backup[2][2];
    //ввод
    for(int i = 0; i < N; i++){
        for(int j = 0; j < 2; j++){
            cin>>ar[i][j];
        }
    }

    //изменение пар на -1 если предыдущая больше следующей
    for(int i = 0; i < N-1; i++)
    {
        if(ar[i+1][0] < ar[i][0] and ar[i+1][1] < ar[i][1])
        {
            ar[i][0] = -1;
            ar[i][1] = -1;
        }
    }
    //изменение пар где одно больше другого на -1

    for(int i = 0; i < N; i++)
    {
        if (ar[i][0] > ar[i][1] or ar[i][0] == ar[i][1])
        {
            ar[i][0] = -1;
            ar[i][1] = -1;
        }
    }
//изменение для макс значения
    for(int i = 0; i < N-1; i++){
        if (abs((ar[i][1] - ar[i+1][0])) != 0 and ar[i][1] != -1 and ar[i+1][0] != -1)
        {
            backup[0][0] = ar[i][0]; //бэкап значений
            backup[0][1] = ar[i][1];
            backup[1][0] = ar[i+1][0];
            backup[1][1] = ar[i+1][1];

            ar[i][1] = ar[i+1][0];

            if(ar[i][1] == ar[i][0]) {
                ar[i][1] = backup[0][1]; //возвращ знач обратно, если не подошли и пробуем другой вариант
                ar[i+1][0] = ar[i][1];
            }
        }

    }

//вывод ответа
    for(int i = 0; i < N; i++){
        for(int j = 0; j < 2; j++){
            cout<<ar[i][j]<< " ";
        }
        cout<<endl;
    }
    return 0;
}
