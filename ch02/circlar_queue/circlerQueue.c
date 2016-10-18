//saori 20161017 circled queue

//이것을 디파인 안해주고 컴파일을 하면 컴파일 에러 코드 c4996이 뜹니다. #pragma warning(disable: 4996)을 써서 warning을 무시할 수도 있습니다.
//SDL C4996: 사용되지 않는 것으로 표시된 함수를 사용함
//warning에 대한 링크 : warning-msdn
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
			printf("1.삽입\n2.삭제\n3.printout\n4.the end\n");
			printf("숫자를 입력하시요: ");
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
				printf("숫자1~4를 입력해주세요.\n");
				break;
			}

		}

		int enqueue() {
			if ((tail + 1) % N == head) {
				printf("errer; overflow.\n");
				return 0;
			}
			printf("삽입할 숫자를 입력하세요: ");
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
				printf("공백 큐입니다.\n");
				//return 0;
			}
			for(i = 0; i < N; i++){
				printf(Q[i] + "\t");
			}
			printf("\n");
			//return 1;
		}

	
