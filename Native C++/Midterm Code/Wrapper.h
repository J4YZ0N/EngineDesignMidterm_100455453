#pragma once
#ifndef __WRAPPER__
#define __WRAPPER__

#include "PluginSettings.h"
#include "Clock.h"

#ifdef __cplusplus
extern "C"
{
#endif

	PLUGIN_API int GetID();

	PLUGIN_API void SetID(int id);

	PLUGIN_API Clock GetTime();

	PLUGIN_API void SetTime(int seconds, int minutes, int hours);

#ifdef __cplusplus
}
#endif

#endif /* defined (__WRAPPER__) */