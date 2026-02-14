## 1. FSM(유한 상태 머신)
- 객체가 한 번에 하나의 상태만 가질 수 있도록 제어하는 모델
[구조]
> **현재 상태 (State) + 조건(Parameter) -> 상태 전이(Transition)**

---
## 2. Unity Animation 구성요소

### 1. 컴포넌트
- Animation
	- 단순한 클립 재생(단밠겅 연출)
	- .anim 파일

- Animator
	- 상태 전이가 활발한데 제어도 필요할 때
	- .controller 파일
	- PRarmeter 탭 수치를 조절

### State (노드)

> 캐릭터가 취할 수 있는 각각의 행동 단위

### Transition (상태 전이 표시, 화살표)

> 상태(State)와 상태(State)를 잇는 통로

