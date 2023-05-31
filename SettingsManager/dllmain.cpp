// dllmain.cpp : Defines the entry point for the DLL application.
#include "pch.h"

#ifdef __cplusplus
extern "C" {
#endif

	void write_settings(const char* path, struct settings settings) {
		FILE* pFile;
		fopen_s(&pFile, path, "wb");
		fwrite(&settings, sizeof(struct settings), 1, pFile);
		fclose(pFile);
	};

	struct settings read_settings(const char* path) {
		FILE* pFile;
		fopen_s(&pFile, path, "rb");
		struct settings* settings = (struct settings*)malloc(sizeof(struct settings));
		fread(settings, sizeof(struct settings), 1, pFile);
		return *settings;
	};

#ifdef __cplusplus
}
#endif
