#include "GameObject.h"

GameObject::GameObject()
{
	SetID();
	SetTime();
}

int GameObject::GetID() const
{
	return m_id;
}

void GameObject::SetID(const int id)
{
	m_id = id;
}

Clock GameObject::GetTime() const
{
	return m_time;
}

void GameObject::SetTime(const int seconds, const int minutes, const int hours)
{
	m_time.seconds = seconds;
	m_time.minutes = minutes;
	m_time.hours = hours;
}