##   
---
## MVP 패턴
### 역할
- **Model**
	- 데이터 관리(값만 가짐, 순수 C#)
	- MonoBehaviour 상속 받지 않음
- **View
	- 그리기만 하는 친구 -> UI 컴포넌트 수정 / 갱신
	- MonoBehaviour 상속 받음
- **Presenter
	- Model(데이터)의 변화를 감지해서 View(화면)에 전달/ 명령 내리는 녀석

### 사고방식

- **Model** : 어떤 데이터를 관리하지? (선언된 데이터)
- **View** : 화면에 뭘 그릴건데?
- **Presenter** :  Model(데이터) 업데이트와 그려줄 View(화면)를 누가 중재 / 관리하나?
---
## 실전 예제
### 1. Basic - 단일연동(1 : 1)

### 2. Advanced - 다중연동 (1 : N)

---

## 안전한 구독 : OnEnable / OnDisable

- Onenable (구독 시작)
- OnDisable (구독 해제)

	👉 밥먹듯이 습관적으로 해주기
---

## 정리
- **MVC** : 프로젝트가 커지면, View와 Model이 꼬이는 (참조가 많이 일어나는) 스파게티 위험이 있다.

- **MVP** : Presenter가 중재 / 관리 해서 Model과 View를 끝까지 깨끗하게 유지 -> 대규모 프로젝트로 가도 문제가 발생할 확률이 적다.