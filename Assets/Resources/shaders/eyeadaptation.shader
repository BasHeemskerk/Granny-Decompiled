Shader "Hidden/Post FX/Eye Adaptation" {
	Properties {
		_MainTex ("Texture", 2D) = "white" {}
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 43065
			Program "vp" {
				SubProgram "d3d11 " {
					"vs_5_0
					
					#version 430
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					precise vec4 u_xlat_precise_vec4;
					precise ivec4 u_xlat_precise_ivec4;
					precise bvec4 u_xlat_precise_bvec4;
					precise uvec4 u_xlat_precise_uvec4;
					UNITY_BINDING(0) uniform VGlobals {
						vec4 unused_0_0[3];
						vec4 _MainTex_ST;
						vec4 unused_0_2[4];
					};
					UNITY_BINDING(1) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					UNITY_BINDING(2) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					layout(location = 0) in  vec4 in_POSITION0;
					layout(location = 1) in  vec4 in_TEXCOORD0;
					layout(location = 0) out vec2 vs_TEXCOORD0;
					layout(location = 1) out vec2 vs_TEXCOORD1;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    vs_TEXCOORD1.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "AUTO_KEY_VALUE" }
					"vs_5_0
					
					#version 430
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					precise vec4 u_xlat_precise_vec4;
					precise ivec4 u_xlat_precise_ivec4;
					precise bvec4 u_xlat_precise_bvec4;
					precise uvec4 u_xlat_precise_uvec4;
					UNITY_BINDING(0) uniform VGlobals {
						vec4 unused_0_0[3];
						vec4 _MainTex_ST;
						vec4 unused_0_2[4];
					};
					UNITY_BINDING(1) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					UNITY_BINDING(2) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					layout(location = 0) in  vec4 in_POSITION0;
					layout(location = 1) in  vec4 in_TEXCOORD0;
					layout(location = 0) out vec2 vs_TEXCOORD0;
					layout(location = 1) out vec2 vs_TEXCOORD1;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    vs_TEXCOORD1.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    return;
					}"
				}
			}
			Program "fp" {
				SubProgram "d3d11 " {
					"ps_5_0
					
					#version 430
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					precise vec4 u_xlat_precise_vec4;
					precise ivec4 u_xlat_precise_ivec4;
					precise bvec4 u_xlat_precise_bvec4;
					precise uvec4 u_xlat_precise_uvec4;
					UNITY_BINDING(0) uniform PGlobals {
						vec4 unused_0_0[4];
						vec4 _Params;
						vec2 _Speed;
						vec4 _ScaleOffsetRes;
						float _ExposureCompensation;
					};
					UNITY_BINDING(1) uniform UnityPerCamera {
						vec4 unused_1_0[3];
						vec4 unity_DeltaTime;
						vec4 unused_1_2[5];
					};
					UNITY_LOCATION(0) uniform  sampler2D _MainTex;
					 struct _Histogram_type {
						uint[1] value;
					};
					
					layout(std430, binding = 0) readonly buffer _Histogram {
						_Histogram_type _Histogram_buf[];
					};
					layout(location = 0) out vec4 SV_Target0;
					float u_xlat0;
					uint u_xlatu0;
					vec3 u_xlat1;
					vec2 u_xlat2;
					vec2 u_xlat3;
					vec2 u_xlat4;
					uint u_xlatu4;
					float u_xlat8;
					uint u_xlatu8;
					bool u_xlatb8;
					float u_xlat9;
					float u_xlat10;
					float u_xlat12;
					uint u_xlatu12;
					bool u_xlatb12;
					float u_xlat13;
					uint u_xlatu13;
					bool u_xlatb13;
					void main()
					{
					    u_xlatu0 = uint(0u);
					    u_xlatu4 = uint(0u);
					    while(true){
					        u_xlatb8 = u_xlatu4>=64u;
					        if(u_xlatb8){break;}
					        u_xlatu8 = _Histogram_buf[u_xlatu4].value[(0 >> 2) + 0];
					        u_xlatu0 = max(u_xlatu8, u_xlatu0);
					        u_xlatu4 = u_xlatu4 + 1u;
					    }
					    u_xlat0 = float(u_xlatu0);
					    u_xlat0 = float(1.0) / u_xlat0;
					    u_xlatu4 = uint(0u);
					    u_xlat8 = float(0.0);
					    while(true){
					        u_xlatb12 = u_xlatu4>=64u;
					        if(u_xlatb12){break;}
					        u_xlatu12 = _Histogram_buf[u_xlatu4].value[(0 >> 2) + 0];
					        u_xlat12 = float(u_xlatu12);
					        u_xlat8 = u_xlat12 * u_xlat0 + u_xlat8;
					        u_xlatu4 = u_xlatu4 + 1u;
					    }
					    u_xlat4.xy = vec2(u_xlat8) * _Params.xy;
					    u_xlat1.xy = u_xlat4.xy;
					    u_xlatu12 = 0u;
					    u_xlat2.x = float(0.0);
					    u_xlat2.y = float(0.0);
					    while(true){
					        u_xlatb13 = u_xlatu12>=64u;
					        if(u_xlatb13){break;}
					        u_xlatu13 = _Histogram_buf[u_xlatu12].value[(0 >> 2) + 0];
					        u_xlat13 = float(u_xlatu13);
					        u_xlat10 = u_xlat0 * u_xlat13;
					        u_xlat10 = min(u_xlat1.x, u_xlat10);
					        u_xlat13 = u_xlat13 * u_xlat0 + (-u_xlat10);
					        u_xlat1.xz = u_xlat1.xy + (-vec2(u_xlat10));
					        u_xlat3.y = min(u_xlat13, u_xlat1.z);
					        u_xlat1.y = u_xlat1.z + (-u_xlat3.y);
					        u_xlat9 = float(u_xlatu12);
					        u_xlat9 = u_xlat9 * 0.015625 + (-_ScaleOffsetRes.y);
					        u_xlat9 = u_xlat9 / _ScaleOffsetRes.x;
					        u_xlat9 = exp2(u_xlat9);
					        u_xlat3.x = u_xlat3.y * u_xlat9;
					        u_xlat2.xy = u_xlat3.xy + u_xlat2.xy;
					        u_xlatu12 = u_xlatu12 + 1u;
					    }
					    u_xlat0 = max(u_xlat2.y, 9.99999975e-05);
					    u_xlat0 = u_xlat2.x / u_xlat0;
					    u_xlat0 = max(u_xlat0, _Params.z);
					    u_xlat0 = min(u_xlat0, _Params.w);
					    u_xlat0 = max(u_xlat0, 9.99999975e-05);
					    u_xlat0 = _ExposureCompensation / u_xlat0;
					    u_xlat4.x = texture(_MainTex, vec2(0.5, 0.5)).x;
					    u_xlat0 = (-u_xlat4.x) + u_xlat0;
					    u_xlatb8 = 0.0<u_xlat0;
					    u_xlat8 = (u_xlatb8) ? _Speed.x : _Speed.y;
					    u_xlat8 = u_xlat8 * (-unity_DeltaTime.x);
					    u_xlat8 = exp2(u_xlat8);
					    u_xlat8 = (-u_xlat8) + 1.0;
					    SV_Target0 = vec4(u_xlat0) * vec4(u_xlat8) + u_xlat4.xxxx;
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "AUTO_KEY_VALUE" }
					"ps_5_0
					
					#version 430
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					precise vec4 u_xlat_precise_vec4;
					precise ivec4 u_xlat_precise_ivec4;
					precise bvec4 u_xlat_precise_bvec4;
					precise uvec4 u_xlat_precise_uvec4;
					UNITY_BINDING(0) uniform PGlobals {
						vec4 unused_0_0[4];
						vec4 _Params;
						vec2 _Speed;
						vec4 _ScaleOffsetRes;
						vec4 unused_0_4;
					};
					UNITY_BINDING(1) uniform UnityPerCamera {
						vec4 unused_1_0[3];
						vec4 unity_DeltaTime;
						vec4 unused_1_2[5];
					};
					UNITY_LOCATION(0) uniform  sampler2D _MainTex;
					 struct _Histogram_type {
						uint[1] value;
					};
					
					layout(std430, binding = 0) readonly buffer _Histogram {
						_Histogram_type _Histogram_buf[];
					};
					layout(location = 0) out vec4 SV_Target0;
					float u_xlat0;
					uint u_xlatu0;
					vec3 u_xlat1;
					vec2 u_xlat2;
					vec2 u_xlat3;
					vec2 u_xlat4;
					uint u_xlatu4;
					float u_xlat8;
					uint u_xlatu8;
					bool u_xlatb8;
					float u_xlat9;
					float u_xlat10;
					float u_xlat12;
					uint u_xlatu12;
					bool u_xlatb12;
					float u_xlat13;
					uint u_xlatu13;
					bool u_xlatb13;
					void main()
					{
					    u_xlatu0 = uint(0u);
					    u_xlatu4 = uint(0u);
					    while(true){
					        u_xlatb8 = u_xlatu4>=64u;
					        if(u_xlatb8){break;}
					        u_xlatu8 = _Histogram_buf[u_xlatu4].value[(0 >> 2) + 0];
					        u_xlatu0 = max(u_xlatu8, u_xlatu0);
					        u_xlatu4 = u_xlatu4 + 1u;
					    }
					    u_xlat0 = float(u_xlatu0);
					    u_xlat0 = float(1.0) / u_xlat0;
					    u_xlatu4 = uint(0u);
					    u_xlat8 = float(0.0);
					    while(true){
					        u_xlatb12 = u_xlatu4>=64u;
					        if(u_xlatb12){break;}
					        u_xlatu12 = _Histogram_buf[u_xlatu4].value[(0 >> 2) + 0];
					        u_xlat12 = float(u_xlatu12);
					        u_xlat8 = u_xlat12 * u_xlat0 + u_xlat8;
					        u_xlatu4 = u_xlatu4 + 1u;
					    }
					    u_xlat4.xy = vec2(u_xlat8) * _Params.xy;
					    u_xlat1.xy = u_xlat4.xy;
					    u_xlatu12 = 0u;
					    u_xlat2.x = float(0.0);
					    u_xlat2.y = float(0.0);
					    while(true){
					        u_xlatb13 = u_xlatu12>=64u;
					        if(u_xlatb13){break;}
					        u_xlatu13 = _Histogram_buf[u_xlatu12].value[(0 >> 2) + 0];
					        u_xlat13 = float(u_xlatu13);
					        u_xlat10 = u_xlat0 * u_xlat13;
					        u_xlat10 = min(u_xlat1.x, u_xlat10);
					        u_xlat13 = u_xlat13 * u_xlat0 + (-u_xlat10);
					        u_xlat1.xz = u_xlat1.xy + (-vec2(u_xlat10));
					        u_xlat3.y = min(u_xlat13, u_xlat1.z);
					        u_xlat1.y = u_xlat1.z + (-u_xlat3.y);
					        u_xlat9 = float(u_xlatu12);
					        u_xlat9 = u_xlat9 * 0.015625 + (-_ScaleOffsetRes.y);
					        u_xlat9 = u_xlat9 / _ScaleOffsetRes.x;
					        u_xlat9 = exp2(u_xlat9);
					        u_xlat3.x = u_xlat3.y * u_xlat9;
					        u_xlat2.xy = u_xlat3.xy + u_xlat2.xy;
					        u_xlatu12 = u_xlatu12 + 1u;
					    }
					    u_xlat0 = max(u_xlat2.y, 9.99999975e-05);
					    u_xlat0 = u_xlat2.x / u_xlat0;
					    u_xlat0 = max(u_xlat0, _Params.z);
					    u_xlat0 = min(u_xlat0, _Params.w);
					    u_xlat0 = max(u_xlat0, 9.99999975e-05);
					    u_xlat4.x = u_xlat0 + 1.0;
					    u_xlat4.x = log2(u_xlat4.x);
					    u_xlat4.x = u_xlat4.x + 2.0;
					    u_xlat4.x = 2.0 / u_xlat4.x;
					    u_xlat4.x = (-u_xlat4.x) + 1.02999997;
					    u_xlat0 = u_xlat4.x / u_xlat0;
					    u_xlat4.x = texture(_MainTex, vec2(0.5, 0.5)).x;
					    u_xlat0 = (-u_xlat4.x) + u_xlat0;
					    u_xlatb8 = 0.0<u_xlat0;
					    u_xlat8 = (u_xlatb8) ? _Speed.x : _Speed.y;
					    u_xlat8 = u_xlat8 * (-unity_DeltaTime.x);
					    u_xlat8 = exp2(u_xlat8);
					    u_xlat8 = (-u_xlat8) + 1.0;
					    SV_Target0 = vec4(u_xlat0) * vec4(u_xlat8) + u_xlat4.xxxx;
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 73179
			Program "vp" {
				SubProgram "d3d11 " {
					"vs_5_0
					
					#version 430
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					precise vec4 u_xlat_precise_vec4;
					precise ivec4 u_xlat_precise_ivec4;
					precise bvec4 u_xlat_precise_bvec4;
					precise uvec4 u_xlat_precise_uvec4;
					UNITY_BINDING(0) uniform VGlobals {
						vec4 unused_0_0[3];
						vec4 _MainTex_ST;
						vec4 unused_0_2[4];
					};
					UNITY_BINDING(1) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					UNITY_BINDING(2) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					layout(location = 0) in  vec4 in_POSITION0;
					layout(location = 1) in  vec4 in_TEXCOORD0;
					layout(location = 0) out vec2 vs_TEXCOORD0;
					layout(location = 1) out vec2 vs_TEXCOORD1;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    vs_TEXCOORD1.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "AUTO_KEY_VALUE" }
					"vs_5_0
					
					#version 430
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					precise vec4 u_xlat_precise_vec4;
					precise ivec4 u_xlat_precise_ivec4;
					precise bvec4 u_xlat_precise_bvec4;
					precise uvec4 u_xlat_precise_uvec4;
					UNITY_BINDING(0) uniform VGlobals {
						vec4 unused_0_0[3];
						vec4 _MainTex_ST;
						vec4 unused_0_2[4];
					};
					UNITY_BINDING(1) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					UNITY_BINDING(2) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					layout(location = 0) in  vec4 in_POSITION0;
					layout(location = 1) in  vec4 in_TEXCOORD0;
					layout(location = 0) out vec2 vs_TEXCOORD0;
					layout(location = 1) out vec2 vs_TEXCOORD1;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    vs_TEXCOORD1.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    return;
					}"
				}
			}
			Program "fp" {
				SubProgram "d3d11 " {
					"ps_5_0
					
					#version 430
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					precise vec4 u_xlat_precise_vec4;
					precise ivec4 u_xlat_precise_ivec4;
					precise bvec4 u_xlat_precise_bvec4;
					precise uvec4 u_xlat_precise_uvec4;
					UNITY_BINDING(0) uniform PGlobals {
						vec4 unused_0_0[4];
						vec4 _Params;
						vec4 unused_0_2;
						vec4 _ScaleOffsetRes;
						float _ExposureCompensation;
					};
					 struct _Histogram_type {
						uint[1] value;
					};
					
					layout(std430, binding = 0) readonly buffer _Histogram {
						_Histogram_type _Histogram_buf[];
					};
					layout(location = 0) out vec4 SV_Target0;
					float u_xlat0;
					uint u_xlatu0;
					vec3 u_xlat1;
					vec2 u_xlat2;
					vec2 u_xlat3;
					vec2 u_xlat4;
					uint u_xlatu4;
					float u_xlat8;
					uint u_xlatu8;
					bool u_xlatb8;
					float u_xlat9;
					float u_xlat10;
					float u_xlat12;
					uint u_xlatu12;
					bool u_xlatb12;
					float u_xlat13;
					uint u_xlatu13;
					bool u_xlatb13;
					void main()
					{
					    u_xlatu0 = uint(0u);
					    u_xlatu4 = uint(0u);
					    while(true){
					        u_xlatb8 = u_xlatu4>=64u;
					        if(u_xlatb8){break;}
					        u_xlatu8 = _Histogram_buf[u_xlatu4].value[(0 >> 2) + 0];
					        u_xlatu0 = max(u_xlatu8, u_xlatu0);
					        u_xlatu4 = u_xlatu4 + 1u;
					    }
					    u_xlat0 = float(u_xlatu0);
					    u_xlat0 = float(1.0) / u_xlat0;
					    u_xlatu4 = uint(0u);
					    u_xlat8 = float(0.0);
					    while(true){
					        u_xlatb12 = u_xlatu4>=64u;
					        if(u_xlatb12){break;}
					        u_xlatu12 = _Histogram_buf[u_xlatu4].value[(0 >> 2) + 0];
					        u_xlat12 = float(u_xlatu12);
					        u_xlat8 = u_xlat12 * u_xlat0 + u_xlat8;
					        u_xlatu4 = u_xlatu4 + 1u;
					    }
					    u_xlat4.xy = vec2(u_xlat8) * _Params.xy;
					    u_xlat1.xy = u_xlat4.xy;
					    u_xlatu12 = 0u;
					    u_xlat2.x = float(0.0);
					    u_xlat2.y = float(0.0);
					    while(true){
					        u_xlatb13 = u_xlatu12>=64u;
					        if(u_xlatb13){break;}
					        u_xlatu13 = _Histogram_buf[u_xlatu12].value[(0 >> 2) + 0];
					        u_xlat13 = float(u_xlatu13);
					        u_xlat10 = u_xlat0 * u_xlat13;
					        u_xlat10 = min(u_xlat1.x, u_xlat10);
					        u_xlat13 = u_xlat13 * u_xlat0 + (-u_xlat10);
					        u_xlat1.xz = u_xlat1.xy + (-vec2(u_xlat10));
					        u_xlat3.y = min(u_xlat13, u_xlat1.z);
					        u_xlat1.y = u_xlat1.z + (-u_xlat3.y);
					        u_xlat9 = float(u_xlatu12);
					        u_xlat9 = u_xlat9 * 0.015625 + (-_ScaleOffsetRes.y);
					        u_xlat9 = u_xlat9 / _ScaleOffsetRes.x;
					        u_xlat9 = exp2(u_xlat9);
					        u_xlat3.x = u_xlat3.y * u_xlat9;
					        u_xlat2.xy = u_xlat3.xy + u_xlat2.xy;
					        u_xlatu12 = u_xlatu12 + 1u;
					    }
					    u_xlat0 = max(u_xlat2.y, 9.99999975e-05);
					    u_xlat0 = u_xlat2.x / u_xlat0;
					    u_xlat0 = max(u_xlat0, _Params.z);
					    u_xlat0 = min(u_xlat0, _Params.w);
					    u_xlat0 = max(u_xlat0, 9.99999975e-05);
					    SV_Target0 = vec4(_ExposureCompensation) / vec4(u_xlat0);
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "AUTO_KEY_VALUE" }
					"ps_5_0
					
					#version 430
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					precise vec4 u_xlat_precise_vec4;
					precise ivec4 u_xlat_precise_ivec4;
					precise bvec4 u_xlat_precise_bvec4;
					precise uvec4 u_xlat_precise_uvec4;
					UNITY_BINDING(0) uniform PGlobals {
						vec4 unused_0_0[4];
						vec4 _Params;
						vec4 unused_0_2;
						vec4 _ScaleOffsetRes;
						vec4 unused_0_4;
					};
					 struct _Histogram_type {
						uint[1] value;
					};
					
					layout(std430, binding = 0) readonly buffer _Histogram {
						_Histogram_type _Histogram_buf[];
					};
					layout(location = 0) out vec4 SV_Target0;
					float u_xlat0;
					uint u_xlatu0;
					vec3 u_xlat1;
					vec2 u_xlat2;
					vec2 u_xlat3;
					vec2 u_xlat4;
					uint u_xlatu4;
					float u_xlat8;
					uint u_xlatu8;
					bool u_xlatb8;
					float u_xlat9;
					float u_xlat10;
					float u_xlat12;
					uint u_xlatu12;
					bool u_xlatb12;
					float u_xlat13;
					uint u_xlatu13;
					bool u_xlatb13;
					void main()
					{
					    u_xlatu0 = uint(0u);
					    u_xlatu4 = uint(0u);
					    while(true){
					        u_xlatb8 = u_xlatu4>=64u;
					        if(u_xlatb8){break;}
					        u_xlatu8 = _Histogram_buf[u_xlatu4].value[(0 >> 2) + 0];
					        u_xlatu0 = max(u_xlatu8, u_xlatu0);
					        u_xlatu4 = u_xlatu4 + 1u;
					    }
					    u_xlat0 = float(u_xlatu0);
					    u_xlat0 = float(1.0) / u_xlat0;
					    u_xlatu4 = uint(0u);
					    u_xlat8 = float(0.0);
					    while(true){
					        u_xlatb12 = u_xlatu4>=64u;
					        if(u_xlatb12){break;}
					        u_xlatu12 = _Histogram_buf[u_xlatu4].value[(0 >> 2) + 0];
					        u_xlat12 = float(u_xlatu12);
					        u_xlat8 = u_xlat12 * u_xlat0 + u_xlat8;
					        u_xlatu4 = u_xlatu4 + 1u;
					    }
					    u_xlat4.xy = vec2(u_xlat8) * _Params.xy;
					    u_xlat1.xy = u_xlat4.xy;
					    u_xlatu12 = 0u;
					    u_xlat2.x = float(0.0);
					    u_xlat2.y = float(0.0);
					    while(true){
					        u_xlatb13 = u_xlatu12>=64u;
					        if(u_xlatb13){break;}
					        u_xlatu13 = _Histogram_buf[u_xlatu12].value[(0 >> 2) + 0];
					        u_xlat13 = float(u_xlatu13);
					        u_xlat10 = u_xlat0 * u_xlat13;
					        u_xlat10 = min(u_xlat1.x, u_xlat10);
					        u_xlat13 = u_xlat13 * u_xlat0 + (-u_xlat10);
					        u_xlat1.xz = u_xlat1.xy + (-vec2(u_xlat10));
					        u_xlat3.y = min(u_xlat13, u_xlat1.z);
					        u_xlat1.y = u_xlat1.z + (-u_xlat3.y);
					        u_xlat9 = float(u_xlatu12);
					        u_xlat9 = u_xlat9 * 0.015625 + (-_ScaleOffsetRes.y);
					        u_xlat9 = u_xlat9 / _ScaleOffsetRes.x;
					        u_xlat9 = exp2(u_xlat9);
					        u_xlat3.x = u_xlat3.y * u_xlat9;
					        u_xlat2.xy = u_xlat3.xy + u_xlat2.xy;
					        u_xlatu12 = u_xlatu12 + 1u;
					    }
					    u_xlat0 = max(u_xlat2.y, 9.99999975e-05);
					    u_xlat0 = u_xlat2.x / u_xlat0;
					    u_xlat0 = max(u_xlat0, _Params.z);
					    u_xlat0 = min(u_xlat0, _Params.w);
					    u_xlat0 = max(u_xlat0, 9.99999975e-05);
					    u_xlat4.x = u_xlat0 + 1.0;
					    u_xlat4.x = log2(u_xlat4.x);
					    u_xlat4.x = u_xlat4.x + 2.0;
					    u_xlat4.x = 2.0 / u_xlat4.x;
					    u_xlat4.x = (-u_xlat4.x) + 1.02999997;
					    SV_Target0 = u_xlat4.xxxx / vec4(u_xlat0);
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 176548
			Program "vp" {
				SubProgram "d3d11 " {
					"vs_5_0
					
					#version 430
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					precise vec4 u_xlat_precise_vec4;
					precise ivec4 u_xlat_precise_ivec4;
					precise bvec4 u_xlat_precise_bvec4;
					precise uvec4 u_xlat_precise_uvec4;
					UNITY_BINDING(0) uniform VGlobals {
						vec4 unused_0_0[4];
						vec4 _Params;
						vec4 unused_0_2;
						vec4 _ScaleOffsetRes;
						vec4 unused_0_4;
					};
					UNITY_BINDING(1) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					UNITY_BINDING(2) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					 struct _Histogram_type {
						uint[1] value;
					};
					
					layout(std430, binding = 0) readonly buffer _Histogram {
						_Histogram_type _Histogram_buf[];
					};
					layout(location = 0) in  vec4 in_POSITION0;
					layout(location = 1) in  vec4 in_TEXCOORD0;
					layout(location = 0) out vec2 vs_TEXCOORD0;
					layout(location = 1) out float vs_TEXCOORD1;
					layout(location = 2) out float vs_TEXCOORD2;
					vec4 u_xlat0;
					uint u_xlatu0;
					vec4 u_xlat1;
					vec2 u_xlat2;
					vec2 u_xlat3;
					vec2 u_xlat4;
					uint u_xlatu4;
					float u_xlat8;
					uint u_xlatu8;
					bool u_xlatb8;
					float u_xlat9;
					float u_xlat10;
					float u_xlat12;
					uint u_xlatu12;
					bool u_xlatb12;
					float u_xlat13;
					uint u_xlatu13;
					bool u_xlatb13;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    u_xlatu0 = uint(0u);
					    u_xlatu4 = uint(0u);
					    while(true){
					        u_xlatb8 = u_xlatu4>=64u;
					        if(u_xlatb8){break;}
					        u_xlatu8 = _Histogram_buf[u_xlatu4].value[(0 >> 2) + 0];
					        u_xlatu0 = max(u_xlatu8, u_xlatu0);
					        u_xlatu4 = u_xlatu4 + 1u;
					    }
					    u_xlat0.x = float(u_xlatu0);
					    u_xlat0.x = float(1.0) / u_xlat0.x;
					    u_xlatu4 = uint(0u);
					    u_xlat8 = float(0.0);
					    while(true){
					        u_xlatb12 = u_xlatu4>=64u;
					        if(u_xlatb12){break;}
					        u_xlatu12 = _Histogram_buf[u_xlatu4].value[(0 >> 2) + 0];
					        u_xlat12 = float(u_xlatu12);
					        u_xlat8 = u_xlat12 * u_xlat0.x + u_xlat8;
					        u_xlatu4 = u_xlatu4 + 1u;
					    }
					    u_xlat4.xy = vec2(u_xlat8) * _Params.xy;
					    u_xlat1.xy = u_xlat4.xy;
					    u_xlatu12 = 0u;
					    u_xlat2.x = float(0.0);
					    u_xlat2.y = float(0.0);
					    while(true){
					        u_xlatb13 = u_xlatu12>=64u;
					        if(u_xlatb13){break;}
					        u_xlatu13 = _Histogram_buf[u_xlatu12].value[(0 >> 2) + 0];
					        u_xlat13 = float(u_xlatu13);
					        u_xlat10 = u_xlat0.x * u_xlat13;
					        u_xlat10 = min(u_xlat1.x, u_xlat10);
					        u_xlat13 = u_xlat13 * u_xlat0.x + (-u_xlat10);
					        u_xlat1.xz = u_xlat1.xy + (-vec2(u_xlat10));
					        u_xlat3.y = min(u_xlat13, u_xlat1.z);
					        u_xlat1.y = u_xlat1.z + (-u_xlat3.y);
					        u_xlat9 = float(u_xlatu12);
					        u_xlat9 = u_xlat9 * 0.015625 + (-_ScaleOffsetRes.y);
					        u_xlat9 = u_xlat9 / _ScaleOffsetRes.x;
					        u_xlat9 = exp2(u_xlat9);
					        u_xlat3.x = u_xlat3.y * u_xlat9;
					        u_xlat2.xy = u_xlat3.xy + u_xlat2.xy;
					        u_xlatu12 = u_xlatu12 + 1u;
					    }
					    u_xlat4.x = max(u_xlat2.y, 9.99999975e-05);
					    u_xlat4.x = u_xlat2.x / u_xlat4.x;
					    u_xlat4.x = max(u_xlat4.x, _Params.z);
					    vs_TEXCOORD2 = min(u_xlat4.x, _Params.w);
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    vs_TEXCOORD1 = u_xlat0.x;
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "AUTO_KEY_VALUE" }
					"vs_5_0
					
					#version 430
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					precise vec4 u_xlat_precise_vec4;
					precise ivec4 u_xlat_precise_ivec4;
					precise bvec4 u_xlat_precise_bvec4;
					precise uvec4 u_xlat_precise_uvec4;
					UNITY_BINDING(0) uniform VGlobals {
						vec4 unused_0_0[4];
						vec4 _Params;
						vec4 unused_0_2;
						vec4 _ScaleOffsetRes;
						vec4 unused_0_4;
					};
					UNITY_BINDING(1) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					UNITY_BINDING(2) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					 struct _Histogram_type {
						uint[1] value;
					};
					
					layout(std430, binding = 0) readonly buffer _Histogram {
						_Histogram_type _Histogram_buf[];
					};
					layout(location = 0) in  vec4 in_POSITION0;
					layout(location = 1) in  vec4 in_TEXCOORD0;
					layout(location = 0) out vec2 vs_TEXCOORD0;
					layout(location = 1) out float vs_TEXCOORD1;
					layout(location = 2) out float vs_TEXCOORD2;
					vec4 u_xlat0;
					uint u_xlatu0;
					vec4 u_xlat1;
					vec2 u_xlat2;
					vec2 u_xlat3;
					vec2 u_xlat4;
					uint u_xlatu4;
					float u_xlat8;
					uint u_xlatu8;
					bool u_xlatb8;
					float u_xlat9;
					float u_xlat10;
					float u_xlat12;
					uint u_xlatu12;
					bool u_xlatb12;
					float u_xlat13;
					uint u_xlatu13;
					bool u_xlatb13;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    u_xlatu0 = uint(0u);
					    u_xlatu4 = uint(0u);
					    while(true){
					        u_xlatb8 = u_xlatu4>=64u;
					        if(u_xlatb8){break;}
					        u_xlatu8 = _Histogram_buf[u_xlatu4].value[(0 >> 2) + 0];
					        u_xlatu0 = max(u_xlatu8, u_xlatu0);
					        u_xlatu4 = u_xlatu4 + 1u;
					    }
					    u_xlat0.x = float(u_xlatu0);
					    u_xlat0.x = float(1.0) / u_xlat0.x;
					    u_xlatu4 = uint(0u);
					    u_xlat8 = float(0.0);
					    while(true){
					        u_xlatb12 = u_xlatu4>=64u;
					        if(u_xlatb12){break;}
					        u_xlatu12 = _Histogram_buf[u_xlatu4].value[(0 >> 2) + 0];
					        u_xlat12 = float(u_xlatu12);
					        u_xlat8 = u_xlat12 * u_xlat0.x + u_xlat8;
					        u_xlatu4 = u_xlatu4 + 1u;
					    }
					    u_xlat4.xy = vec2(u_xlat8) * _Params.xy;
					    u_xlat1.xy = u_xlat4.xy;
					    u_xlatu12 = 0u;
					    u_xlat2.x = float(0.0);
					    u_xlat2.y = float(0.0);
					    while(true){
					        u_xlatb13 = u_xlatu12>=64u;
					        if(u_xlatb13){break;}
					        u_xlatu13 = _Histogram_buf[u_xlatu12].value[(0 >> 2) + 0];
					        u_xlat13 = float(u_xlatu13);
					        u_xlat10 = u_xlat0.x * u_xlat13;
					        u_xlat10 = min(u_xlat1.x, u_xlat10);
					        u_xlat13 = u_xlat13 * u_xlat0.x + (-u_xlat10);
					        u_xlat1.xz = u_xlat1.xy + (-vec2(u_xlat10));
					        u_xlat3.y = min(u_xlat13, u_xlat1.z);
					        u_xlat1.y = u_xlat1.z + (-u_xlat3.y);
					        u_xlat9 = float(u_xlatu12);
					        u_xlat9 = u_xlat9 * 0.015625 + (-_ScaleOffsetRes.y);
					        u_xlat9 = u_xlat9 / _ScaleOffsetRes.x;
					        u_xlat9 = exp2(u_xlat9);
					        u_xlat3.x = u_xlat3.y * u_xlat9;
					        u_xlat2.xy = u_xlat3.xy + u_xlat2.xy;
					        u_xlatu12 = u_xlatu12 + 1u;
					    }
					    u_xlat4.x = max(u_xlat2.y, 9.99999975e-05);
					    u_xlat4.x = u_xlat2.x / u_xlat4.x;
					    u_xlat4.x = max(u_xlat4.x, _Params.z);
					    vs_TEXCOORD2 = min(u_xlat4.x, _Params.w);
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    vs_TEXCOORD1 = u_xlat0.x;
					    return;
					}"
				}
			}
			Program "fp" {
				SubProgram "d3d11 " {
					"ps_5_0
					
					#version 430
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					precise vec4 u_xlat_precise_vec4;
					precise ivec4 u_xlat_precise_ivec4;
					precise bvec4 u_xlat_precise_bvec4;
					precise uvec4 u_xlat_precise_uvec4;
					UNITY_BINDING(0) uniform PGlobals {
						vec4 unused_0_0[4];
						vec4 _Params;
						vec4 unused_0_2;
						vec4 _ScaleOffsetRes;
						int _DebugWidth;
					};
					 struct _Histogram_type {
						uint[1] value;
					};
					
					layout(std430, binding = 0) readonly buffer _Histogram {
						_Histogram_type _Histogram_buf[];
					};
					layout(location = 0) in  vec2 vs_TEXCOORD0;
					layout(location = 1) in  float vs_TEXCOORD1;
					layout(location = 2) in  float vs_TEXCOORD2;
					layout(location = 0) out vec4 SV_Target0;
					vec3 u_xlat0;
					bool u_xlatb0;
					vec3 u_xlat1;
					float u_xlat2;
					uint u_xlatu2;
					bool u_xlatb2;
					float u_xlat4;
					float u_xlat6;
					bool u_xlatb6;
					void main()
					{
					vec4 hlslcc_FragCoord = vec4(gl_FragCoord.xyz, 1.0/gl_FragCoord.w);
					    u_xlat0.xy = log2(_Params.zw);
					    u_xlat0.xy = u_xlat0.xy * _ScaleOffsetRes.xx + _ScaleOffsetRes.yy;
					    u_xlat0.xy = clamp(u_xlat0.xy, 0.0, 1.0);
					    u_xlatb0 = u_xlat0.x<vs_TEXCOORD0.x;
					    u_xlatb2 = vs_TEXCOORD0.x<u_xlat0.y;
					    u_xlatb0 = u_xlatb2 && u_xlatb0;
					    u_xlat2 = vs_TEXCOORD0.x * 64.0;
					    u_xlat2 = roundEven(u_xlat2);
					    u_xlatu2 = uint(u_xlat2);
					    u_xlatu2 = _Histogram_buf[u_xlatu2].value[(0 >> 2) + 0];
					    u_xlat2 = float(u_xlatu2);
					    u_xlat2 = u_xlat2 * vs_TEXCOORD1;
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					    u_xlatb2 = u_xlat2>=vs_TEXCOORD0.y;
					    u_xlat4 = u_xlatb2 ? 1.0 : float(0.0);
					    u_xlat1.xyz = (bool(u_xlatb2)) ? vec3(0.100000001, 0.800000012, 1.20000005) : vec3(0.0500000007, 0.400000006, 0.600000024);
					    u_xlat0.xyz = (bool(u_xlatb0)) ? u_xlat1.xyz : vec3(u_xlat4);
					    u_xlat6 = log2(vs_TEXCOORD2);
					    u_xlat6 = u_xlat6 * _ScaleOffsetRes.x + _ScaleOffsetRes.y;
					    u_xlat6 = clamp(u_xlat6, 0.0, 1.0);
					    u_xlat1.x = float(_DebugWidth);
					    u_xlat6 = (-u_xlat6) * u_xlat1.x + hlslcc_FragCoord.x;
					    u_xlatb6 = abs(u_xlat6)<2.0;
					    SV_Target0.xyz = (bool(u_xlatb6)) ? vec3(0.800000012, 0.300000012, 0.0500000007) : u_xlat0.xyz;
					    SV_Target0.w = 0.699999988;
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "AUTO_KEY_VALUE" }
					"ps_5_0
					
					#version 430
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					precise vec4 u_xlat_precise_vec4;
					precise ivec4 u_xlat_precise_ivec4;
					precise bvec4 u_xlat_precise_bvec4;
					precise uvec4 u_xlat_precise_uvec4;
					UNITY_BINDING(0) uniform PGlobals {
						vec4 unused_0_0[4];
						vec4 _Params;
						vec4 unused_0_2;
						vec4 _ScaleOffsetRes;
						int _DebugWidth;
					};
					 struct _Histogram_type {
						uint[1] value;
					};
					
					layout(std430, binding = 0) readonly buffer _Histogram {
						_Histogram_type _Histogram_buf[];
					};
					layout(location = 0) in  vec2 vs_TEXCOORD0;
					layout(location = 1) in  float vs_TEXCOORD1;
					layout(location = 2) in  float vs_TEXCOORD2;
					layout(location = 0) out vec4 SV_Target0;
					vec3 u_xlat0;
					bool u_xlatb0;
					vec3 u_xlat1;
					float u_xlat2;
					uint u_xlatu2;
					bool u_xlatb2;
					float u_xlat4;
					float u_xlat6;
					bool u_xlatb6;
					void main()
					{
					vec4 hlslcc_FragCoord = vec4(gl_FragCoord.xyz, 1.0/gl_FragCoord.w);
					    u_xlat0.xy = log2(_Params.zw);
					    u_xlat0.xy = u_xlat0.xy * _ScaleOffsetRes.xx + _ScaleOffsetRes.yy;
					    u_xlat0.xy = clamp(u_xlat0.xy, 0.0, 1.0);
					    u_xlatb0 = u_xlat0.x<vs_TEXCOORD0.x;
					    u_xlatb2 = vs_TEXCOORD0.x<u_xlat0.y;
					    u_xlatb0 = u_xlatb2 && u_xlatb0;
					    u_xlat2 = vs_TEXCOORD0.x * 64.0;
					    u_xlat2 = roundEven(u_xlat2);
					    u_xlatu2 = uint(u_xlat2);
					    u_xlatu2 = _Histogram_buf[u_xlatu2].value[(0 >> 2) + 0];
					    u_xlat2 = float(u_xlatu2);
					    u_xlat2 = u_xlat2 * vs_TEXCOORD1;
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					    u_xlatb2 = u_xlat2>=vs_TEXCOORD0.y;
					    u_xlat4 = u_xlatb2 ? 1.0 : float(0.0);
					    u_xlat1.xyz = (bool(u_xlatb2)) ? vec3(0.100000001, 0.800000012, 1.20000005) : vec3(0.0500000007, 0.400000006, 0.600000024);
					    u_xlat0.xyz = (bool(u_xlatb0)) ? u_xlat1.xyz : vec3(u_xlat4);
					    u_xlat6 = log2(vs_TEXCOORD2);
					    u_xlat6 = u_xlat6 * _ScaleOffsetRes.x + _ScaleOffsetRes.y;
					    u_xlat6 = clamp(u_xlat6, 0.0, 1.0);
					    u_xlat1.x = float(_DebugWidth);
					    u_xlat6 = (-u_xlat6) * u_xlat1.x + hlslcc_FragCoord.x;
					    u_xlatb6 = abs(u_xlat6)<2.0;
					    SV_Target0.xyz = (bool(u_xlatb6)) ? vec3(0.800000012, 0.300000012, 0.0500000007) : u_xlat0.xyz;
					    SV_Target0.w = 0.699999988;
					    return;
					}"
				}
			}
		}
	}
}