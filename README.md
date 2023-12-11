# 강의 노트
---
루키스 C# 강의 노트

## 쓰레드 생성
---
* C#의 쓰레드는 기본적으로 Foreground
* IsBackground로 설정 가능, 기본 설정은 false
* Join()을 이용해서 기다릴 수 있음
* 가벼운 작업에 쓰레드를 생성하는 것은 비효율적
	* C# ThreadPool 사용(백그라운드)
* 쓰레드 많아짐->문맥교환 오버헤드
* Task 생성 시 옵션넣기 가능
	* TaskCreateOptions