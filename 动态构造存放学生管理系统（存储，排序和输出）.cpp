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

	// ��̬�Ĺ���һά����
	printf("������ѧ����������\n");
	printf("len = ");
	scanf("%d", &len);
	parr = (struct student *)malloc(len * sizeof(struct student));

	for(i=0; i<len; i++)
	{
		printf("������%d��ѧ������Ϣ��\n", i+1);
		printf("age = ");
		scanf("%d", &parr[i].age);

		printf("name = ");
		scanf("%s", parr[i].name); //name����������������Ѿ���������Ԫ�صĵ�ַ������parr[i].name���ܹ��ó�&parr[i].name��

		printf("score = ");
		scanf("%f", &parr[i].score);
	}

	//����ѧ���ɼ��������� ð���㷨
	for(i=0; i<len-1; i++)
	{
		for(j=0; j<len-1-i; j++)
		{
			if(parr[j].score > parr[j+1].score) //>������<������
			{
				temp = parr[j];
				parr[j] = parr[j+1];
				parr[j+1] = temp;
			}
		}
	}

	printf("\n\nѧ������Ϣ�ǣ�\n");
	//���
	for(i=0; i<len; i++)
	{
		printf("��%d��ѧ������Ϣ��\n", i+1);
		printf("age = %d\n", parr[i].age);
		printf("name = %s\n", parr[i].name);
		printf("score = %f\n", parr[i].score);

		printf("\n");
	}


	system("pause");
	return 0;
}