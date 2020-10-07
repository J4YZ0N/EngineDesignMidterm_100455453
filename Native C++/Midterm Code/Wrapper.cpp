#include "Wrapper.h"
#include "GameObject.h"

GameObject gameObject;

PLUGIN_API int GetID()
{
	return gameObject.GetID();
}

PLUGIN_API void SetID(const int id)
{
	gameObject.SetID(id);
}

PLUGIN_API Clock GetTime()
{
	return gameObject.GetTime();
}

PLUGIN_API void SetTime(const int seconds, const int minutes, const int hours)
{
	gameObject.SetTime(seconds, minutes, hours);
}