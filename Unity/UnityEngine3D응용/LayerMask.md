## 1. **Layer** VS **LayerMask**
[Layer]
- 오브젝트는 단 하나의 레이어(Layer)만 가질 수 있다.
- LayerMask.NameToLayer("Player") 이렇게 이름을 통해서 레이어 인덱스(0번 ~ 31번)를 가져온다.

[LayerMask]
- 사용 예시 
  ```csharp
  // 특정 레이어 선택
  LayerMask mask = LayerMask.GetMask("Enemy", "Obstacle");
  
  // 여러 레이어 선택
  int layerMask = 1 << LayerMask.NameToLayer("Enemy");
  
   if(Physics.Raycast(transform.position, transform.forward, out hit, 10f, mask))
   {
	   
   }
  ```
[LayerMask 함수 종류]
1. LayerMask.GetMask
	레이어 이름 묶음을 생성하는 함수
	
	```csharp
		LayerMask.GetMask("Enemy", "Obstacle");
		// Enemy가 8번 레이어라면?
		// 1 << 8 (256)
	```
2. LayerMask.NameToLayer
	레이어의 인덱스(int)를 반환
```csharp
LayerMask.NameToLayer("Enemy");
// int 반환값 = 8
```
3. Layer.Mask.LayerToName
	레이어의 이름을 반환
	```csharp
	LayerMask.LayertoName(8);
	```
4. LayerMask.value
	비트마스크 값을 나타낸다. 주로 비트 연산 수행
	```csharp
	int bitMask = enemyLayer.Value | obstacleLayer.Value;(OR 연산)
	```
	
---

## 2. 비트 연산의 원리
- **1<<n** : n번 레이어의 스위치를 켠다
- **|(OR)** : 필터에 레이어를 추가한다.
- **&(AND)** : 이 오브젝트가 포함되어 있어(필터 역할)
- **~(NOT)** : 지정한 레이어 제외한 나머지 다 선택
```csharp
layerMask = 7;
// 이진수 111 -> 0, 1, 2 
```
layerMask = 7;

	0000 0000 0000 0000 0000 0000 0000 0000 0111
layerMask= 1<<7;

	0000 0000 0000 0000 0000 0000 0000 1000 0000

---

## 3. 특정 레이어 포함 여부 체크(& AND) - 제일 많이 사용
```csharp
public static class Extensions
{
	public static bool Contains(this LayerMask mask, int layer)
	{
		return(mask.value & (1 << layer)) != 0;
	}
}

if(mask.Contains(ob, layer))
{
	
}
```

### 4. 시나리오 A. Monster를 때렸을 때, 공격 가능 여부 체크
```csharp
if(mask.Contains(몬스터 obj, Enemy 마스크))
{
}

(this LayerMask mask, GameObject obj)
```
	Enemy는 8번 레이어
	mask 0000 0000 0000 0000 0000 0000 0001 0000 0000
	
	1 << NPC 0000 0000 0000 0000 0000 0000 0000 1000 0000 &
	0000 0000 0000 0000 0000 0000 0000 0000 0000 **false (공격 무시)**
---

### ~ (NOT) 연산자

```cs
~(1 << PlayerLayer)

// UI 레이어까지 포함
```

---

### 왜 비트마스크 방식을 사용하는지?

```cs
if(taget =="" || target == "" || target == "" || .....)

맞는지 아닌지 하나씩 확인하는 대신에

if(mask.Contains(target, layer))
{
	
}
```

---

## Keyword

- Layer와 LayerMask 개념 이해하기
- LayerMask 함수 종류
- Layer 간 비트연산
- 확장메서드(Extensions) LayerMask.Contains 응용사례