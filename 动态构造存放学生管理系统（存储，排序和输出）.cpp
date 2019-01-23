# include <stdio.h>
# include <stdlib.h>
# include <malloc.h>

struct student
{
	int age;
	float score;
	char name[100];
};

int main(void)
{
	int len;
	struct student * parr;
	int i;
	int j;
	struct student temp;

	// 动态的构造一维数组
	printf("请输入学生的人数：\n");
	printf("len = ");
	scanf("%d", &len);
	parr = (struct student *)malloc(len * sizeof(struct student));

	for(i=0; i<len; i++)
	{
		printf("请输入%d个学生的信息：\n", i+1);
		printf("age = ");
		scanf("%d", &parr[i].age);

		printf("name = ");
		scanf("%s", parr[i].name); //name是数组名，本身就已经是数组首元素的地址，所以parr[i].name不能够该成&parr[i].name，

		printf("score = ");
		scanf("%f", &parr[i].score);
	}

	//按照学生成绩升序排序 冒泡算法
	for(i=0; i<len-1; i++)
	{
		for(j=0; j<len-1-i; j++)
		{
			if(parr[j].score > parr[j+1].score) //>是升序，<是排序
			{
				temp = parr[j];
				parr[j] = parr[j+1];
				parr[j+1] = temp;
			}
		}
	}

	printf("\n\n学生的信息是：\n");
	//输出
	for(i=0; i<len; i++)
	{
		printf("第%d个学生的信息：\n", i+1);
		printf("age = %d\n", parr[i].age);
		printf("name = %s\n", parr[i].name);
		printf("score = %f\n", parr[i].score);

		printf("\n");
	}


	system("pause");
	return 0;
}