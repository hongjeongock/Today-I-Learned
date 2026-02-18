1. 범위 내에 적이 들어 왔는지?
- OnTriggerEnter => 들어왔을때
	List에 추가
- OnTriggerExit => 나갔을때
	List에서 삭제

FixedUpdate
- List.Count != 0이라면? (몬스터가 들어있다면)
	- 거리가 가장 가까운 적 선택
	- 가장 가까운 적 한테만 Raycast발사
	- Raycast에 걸린게 몬스터라면
		- 공격
	- 몬스터가 아니라면
		- 암것도 안함
```csharp
private transform GetClosetEnemise()
{
	// 리스트레 아무것도 안들어있거나 , 리스트가 null이라면?
	if(_enemies.Count == 0 || _enemies == null) return null;
	
	// 리스트에 들어있는 첫 번째 몬스터와 거리를 미리 계산
	Transform closet = _enemies[0];
	float distance = Vector3.Distance(_enmies[0].position, transform.position)
	
	// 두번째 몬스터부터 비교
	for(int i = 1; i < _enemies.Count; i++)
	{
		// 현재(i번째) 몬스터의 거리 계산
		float distance = Vector3.Distance(_enmies[i].position, transform.position)
		
		// 현재 거리가 이전에 계산한 거리보다 적다면
		if(currentDistance < distance)
		{
			// 기존 데이터 초기화
			distance = currentDistance;
			closet = _enemies[i];
		}
	}
	return cloeset;
}

private void FixdUpdate()
{
	if( _enemies[0] != null &&_enemies.Count > 0)
	{
		_target = GetClosetEnemies();
	}
	else
	{
		_target = null;
	}
	
	if(_target != null)
	{
		//레이 쏘면 됨
	}
}
private void IsBlockedByWall(Transform target)
{
	Vector3 direction = target.position - transform.posirion;
	float distance = Vector3.Distance(transform.position, target.positoin)
	
	Ray ray = new Ray(transform.position, dire)
}
```