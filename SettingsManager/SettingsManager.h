#pragma once

#define SETTINGS_MANAGER_H

#ifdef __cplusplus
extern "C" {
#endif

	__declspec(dllimport) struct settings {
		float spawn_interval;
		float move_speed;
	};

	__declspec(dllimport) void write_settings(const char*, struct settings);
	__declspec(dllimport) struct settings read_settings(const char*);

#ifdef __cplusplus
}
#endif
