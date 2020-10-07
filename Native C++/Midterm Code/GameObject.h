#pragma once
#ifndef __GAME_OBJECT__
#define __GAME_OBJECT__

#include "PluginSettings.h"
#include "Clock.h"

class PLUGIN_API GameObject
{
public:
	// Constructor
	GameObject();

	// Getters and Setters
	int GetID() const;
	void SetID(int id = 0);

	Clock GetTime() const;
	void SetTime(int seconds = 0, int minutes = 0, int hours = 0);


private:
	int m_id;
	Clock m_time;

};

#endif /* definted (__GAME_OBJECT__) */