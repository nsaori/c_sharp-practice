//saori 20161017 circled queue

//�̰��� ������ �����ְ� �������� �ϸ� ������ ���� �ڵ� c4996�� ��ϴ�. #pragma warning(disable: 4996)�� �Ἥ warning�� ������ ���� �ֽ��ϴ�.
//SDL C4996: ������ �ʴ� ������ ǥ�õ� �Լ��� �����
//warning�� ���� ��ũ : warning-msdn
//http://cmm.khu.ac.kr/korean/viewtopic.php?popup=yes&today=no&printable=yes&t=2913&postdays=0&postorder=desc&start=
//http://swprog.tistory.com/entry/Visual-studio-2015-scanf-warning-%EC%B2%98%EB%A6%AC-%EB%B0%A9%EB%B2%95%EC%97%90-%EB%8C%80%ED%95%98%EC%97%AC
#define _CRT_SECURE_NO_WARNINGS 
#include<stdio.h>
#include<stdlib.h>

#define N 5

int Q[N] = { 0 };
int head = 0, tail = 0;
int enqueue();
int dequeue();
void printData();

	 void main()
		{
			int choice;
			printf("1.����\n2.����\n3.printout\n4.the end\n");
			printf("���ڸ� �Է��Ͻÿ�: ");
			scanf("%d",&choice);

			switch (choice) {
			case 1:
				enqueue();
				break;
			case 2:
				dequeue();
				break;
			case 3:
				printData();
				break;
			case 4:
				printf("the end\n");
				exit(0);

			default:
				printf("����1~4�� �Է����ּ���.\n");
				break;
			}

		}

		int enqueue() {
			if ((tail + 1) % N == head) {
				printf("errer; overflow.\n");
				return 0;
			}
			printf("������ ���ڸ� �Է��ϼ���: ");
			tail = (tail + 1) % N;
			sacnf("%d", &Q[tail]);
			return 1;
		}

		int dequeue() {
			if (head == tail) {
				printf("errer; underflow.\n");
				return 0;
			}
			head = (head + 1) % N;
			Q[head] = 0;
			return 1;
		}

		void printData() {
			int i;
			if (head == tail)
			{
				printf("���� ť�Դϴ�.\n");
				//return 0;
			}
			for(i = 0; i < N; i++){
				printf(Q[i] + "\t");
			}
			printf("\n");
			//return 1;
		}

	
