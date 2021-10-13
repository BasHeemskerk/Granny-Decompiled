Shader "Hidden/Post FX/FXAA" {
	Properties {
		_MainTex ("Texture", 2D) = "white" {}
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 43352
			Program "vp" {
				SubProgram "d3d11 " {
					"vs_4_0
					
					#version 330
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
					layout(std140) uniform VGlobals {
						vec4 unused_0_0[3];
						vec4 _MainTex_ST;
						vec4 unused_0_2[5];
					};
					layout(std140) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					layout(std140) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					in  vec4 in_POSITION0;
					in  vec4 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					out vec2 vs_TEXCOORD1;
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
					Keywords { "DITHERING" }
					"vs_4_0
					
					#version 330
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
					layout(std140) uniform VGlobals {
						vec4 unused_0_0[3];
						vec4 _MainTex_ST;
						vec4 unused_0_2[5];
					};
					layout(std140) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					layout(std140) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					in  vec4 in_POSITION0;
					in  vec4 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					out vec2 vs_TEXCOORD1;
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
					Keywords { "GRAIN" }
					"vs_4_0
					
					#version 330
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
					layout(std140) uniform VGlobals {
						vec4 unused_0_0[3];
						vec4 _MainTex_ST;
						vec4 unused_0_2[5];
					};
					layout(std140) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					layout(std140) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					in  vec4 in_POSITION0;
					in  vec4 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					out vec2 vs_TEXCOORD1;
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
					Keywords { "GRAIN" "DITHERING" }
					"vs_4_0
					
					#version 330
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
					layout(std140) uniform VGlobals {
						vec4 unused_0_0[3];
						vec4 _MainTex_ST;
						vec4 unused_0_2[5];
					};
					layout(std140) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					layout(std140) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					in  vec4 in_POSITION0;
					in  vec4 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					out vec2 vs_TEXCOORD1;
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
					"ps_4_0
					
					#version 330
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
					layout(std140) uniform PGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 _MainTex_ST;
						vec4 unused_0_3[3];
						vec3 _QualitySettings;
						vec4 unused_0_5;
					};
					uniform  sampler2D _MainTex;
					in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					vec2 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					int u_xlati3;
					bvec2 u_xlatb3;
					vec4 u_xlat4;
					vec4 u_xlat5;
					vec4 u_xlat6;
					vec4 u_xlat7;
					vec4 u_xlat8;
					vec4 u_xlat9;
					vec2 u_xlat12;
					bvec2 u_xlatb12;
					float u_xlat13;
					ivec2 u_xlati13;
					float u_xlat15;
					ivec3 u_xlati15;
					float u_xlat20;
					float u_xlat22;
					float u_xlat23;
					ivec2 u_xlati23;
					bool u_xlatb23;
					float u_xlat24;
					float u_xlat25;
					float u_xlat30;
					bool u_xlatb30;
					float u_xlat32;
					float u_xlat33;
					float u_xlat35;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    u_xlat1 = textureLod(_MainTex, u_xlat0.xy, 0.0);
					    u_xlat2 = _MainTex_TexelSize.xyxy * vec4(0.0, 1.0, 1.0, 0.0) + u_xlat0.xyxy;
					    u_xlat3 = textureLod(_MainTex, u_xlat2.xy, 0.0);
					    u_xlat2 = textureLod(_MainTex, u_xlat2.zw, 0.0);
					    u_xlat4 = _MainTex_TexelSize.xyxy * vec4(0.0, -1.0, -1.0, 0.0) + u_xlat0.xyxy;
					    u_xlat5 = textureLod(_MainTex, u_xlat4.xy, 0.0);
					    u_xlat4 = textureLod(_MainTex, u_xlat4.zw, 0.0);
					    u_xlat20 = max(u_xlat1.y, u_xlat3.y);
					    u_xlat30 = min(u_xlat1.y, u_xlat3.y);
					    u_xlat20 = max(u_xlat20, u_xlat2.y);
					    u_xlat30 = min(u_xlat30, u_xlat2.y);
					    u_xlat2.x = max(u_xlat4.y, u_xlat5.y);
					    u_xlat22 = min(u_xlat4.y, u_xlat5.y);
					    u_xlat20 = max(u_xlat20, u_xlat2.x);
					    u_xlat30 = min(u_xlat30, u_xlat22);
					    u_xlat2.x = u_xlat20 * _QualitySettings.y;
					    u_xlat20 = (-u_xlat30) + u_xlat20;
					    u_xlat30 = max(u_xlat2.x, _QualitySettings.z);
					    u_xlatb30 = u_xlat20>=u_xlat30;
					    if(u_xlatb30){
					        u_xlat2.xz = u_xlat0.xy + (-_MainTex_TexelSize.xy);
					        u_xlat6 = textureLod(_MainTex, u_xlat2.xz, 0.0);
					        u_xlat2.xz = u_xlat0.xy + _MainTex_TexelSize.xy;
					        u_xlat7 = textureLod(_MainTex, u_xlat2.xz, 0.0);
					        u_xlat8 = _MainTex_TexelSize.xyxy * vec4(1.0, -1.0, -1.0, 1.0) + u_xlat0.xyxy;
					        u_xlat9 = textureLod(_MainTex, u_xlat8.xy, 0.0);
					        u_xlat8 = textureLod(_MainTex, u_xlat8.zw, 0.0);
					        u_xlat30 = u_xlat3.y + u_xlat5.y;
					        u_xlat2.x = u_xlat2.y + u_xlat4.y;
					        u_xlat20 = float(1.0) / u_xlat20;
					        u_xlat22 = u_xlat30 + u_xlat2.x;
					        u_xlat30 = u_xlat1.y * -2.0 + u_xlat30;
					        u_xlat2.x = u_xlat1.y * -2.0 + u_xlat2.x;
					        u_xlat32 = u_xlat7.y + u_xlat9.y;
					        u_xlat3.x = u_xlat6.y + u_xlat9.y;
					        u_xlat23 = u_xlat2.y * -2.0 + u_xlat32;
					        u_xlat3.x = u_xlat5.y * -2.0 + u_xlat3.x;
					        u_xlat33 = u_xlat6.y + u_xlat8.y;
					        u_xlat4.x = u_xlat7.y + u_xlat8.y;
					        u_xlat30 = abs(u_xlat30) * 2.0 + abs(u_xlat23);
					        u_xlat2.x = abs(u_xlat2.x) * 2.0 + abs(u_xlat3.x);
					        u_xlat3.x = u_xlat4.y * -2.0 + u_xlat33;
					        u_xlat23 = u_xlat3.y * -2.0 + u_xlat4.x;
					        u_xlat30 = u_xlat30 + abs(u_xlat3.x);
					        u_xlat2.x = u_xlat2.x + abs(u_xlat23);
					        u_xlat32 = u_xlat32 + u_xlat33;
					        u_xlatb30 = u_xlat30>=u_xlat2.x;
					        u_xlat2.x = u_xlat22 * 2.0 + u_xlat32;
					        u_xlat12.y = (u_xlatb30) ? u_xlat5.y : u_xlat4.y;
					        u_xlat12.x = (u_xlatb30) ? u_xlat3.y : u_xlat2.y;
					        u_xlat32 = (u_xlatb30) ? _MainTex_TexelSize.y : _MainTex_TexelSize.x;
					        u_xlat2.x = u_xlat2.x * 0.0833333358 + (-u_xlat1.y);
					        u_xlat3.xy = (-u_xlat1.yy) + u_xlat12.yx;
					        u_xlat12.xy = u_xlat1.yy + u_xlat12.xy;
					        u_xlatb23 = abs(u_xlat3.x)>=abs(u_xlat3.y);
					        u_xlat3.x = max(abs(u_xlat3.y), abs(u_xlat3.x));
					        u_xlat32 = (u_xlatb23) ? (-u_xlat32) : u_xlat32;
					        u_xlat20 = u_xlat20 * abs(u_xlat2.x);
					        u_xlat20 = clamp(u_xlat20, 0.0, 1.0);
					        u_xlat2.x = u_xlatb30 ? _MainTex_TexelSize.x : float(0.0);
					        u_xlat13 = (u_xlatb30) ? 0.0 : _MainTex_TexelSize.y;
					        u_xlat4.xy = vec2(u_xlat32) * vec2(0.5, 0.5) + u_xlat0.xy;
					        u_xlat33 = (u_xlatb30) ? u_xlat0.x : u_xlat4.x;
					        u_xlat4.x = (u_xlatb30) ? u_xlat4.y : u_xlat0.y;
					        u_xlat5.x = (-u_xlat2.x) + u_xlat33;
					        u_xlat5.y = (-u_xlat13) + u_xlat4.x;
					        u_xlat6.x = u_xlat2.x + u_xlat33;
					        u_xlat6.y = u_xlat13 + u_xlat4.x;
					        u_xlat33 = u_xlat20 * -2.0 + 3.0;
					        u_xlat4 = textureLod(_MainTex, u_xlat5.xy, 0.0);
					        u_xlat20 = u_xlat20 * u_xlat20;
					        u_xlat7 = textureLod(_MainTex, u_xlat6.xy, 0.0);
					        u_xlat12.x = (u_xlatb23) ? u_xlat12.y : u_xlat12.x;
					        u_xlat22 = u_xlat3.x * 0.25;
					        u_xlat3.x = (-u_xlat12.x) * 0.5 + u_xlat1.y;
					        u_xlat20 = u_xlat20 * u_xlat33;
					        u_xlati3 = int((u_xlat3.x<0.0) ? 0xFFFFFFFFu : uint(0));
					        u_xlat4.y = (-u_xlat12.x) * 0.5 + u_xlat4.y;
					        u_xlat4.x = (-u_xlat12.x) * 0.5 + u_xlat7.y;
					        u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					        u_xlat25 = (-u_xlat2.x) + u_xlat5.x;
					        u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat25;
					        u_xlat35 = (-u_xlat13) + u_xlat5.y;
					        u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.y : u_xlat35;
					        u_xlati15.xz = ~(u_xlati23.xy);
					        u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					        u_xlat35 = u_xlat2.x + u_xlat6.x;
					        u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					        u_xlat35 = u_xlat13 + u_xlat6.y;
					        u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.y : u_xlat35;
					        if(u_xlati15.x != 0) {
					            if(u_xlati23.x == 0) {
					                u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					            } else {
					                u_xlat7.x = u_xlat4.y;
					            }
					            if(u_xlati23.y == 0) {
					                u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					            }
					            u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					            u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					            u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					            u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					            u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					            u_xlat15 = (-u_xlat2.x) + u_xlat5.x;
					            u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					            u_xlat15 = (-u_xlat13) + u_xlat5.z;
					            u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					            u_xlati15.xz = ~(u_xlati23.xy);
					            u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					            u_xlat35 = u_xlat2.x + u_xlat6.x;
					            u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					            u_xlat35 = u_xlat13 + u_xlat6.z;
					            u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					            if(u_xlati15.x != 0) {
					                if(u_xlati23.x == 0) {
					                    u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                } else {
					                    u_xlat7.x = u_xlat4.y;
					                }
					                if(u_xlati23.y == 0) {
					                    u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                }
					                u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                u_xlat15 = (-u_xlat2.x) + u_xlat5.x;
					                u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                u_xlat15 = (-u_xlat13) + u_xlat5.z;
					                u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                u_xlati15.xz = ~(u_xlati23.xy);
					                u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                u_xlat35 = u_xlat2.x + u_xlat6.x;
					                u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                u_xlat35 = u_xlat13 + u_xlat6.z;
					                u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                if(u_xlati15.x != 0) {
					                    if(u_xlati23.x == 0) {
					                        u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                    } else {
					                        u_xlat7.x = u_xlat4.y;
					                    }
					                    if(u_xlati23.y == 0) {
					                        u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                    }
					                    u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                    u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                    u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                    u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                    u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                    u_xlat15 = (-u_xlat2.x) + u_xlat5.x;
					                    u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                    u_xlat15 = (-u_xlat13) + u_xlat5.z;
					                    u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                    u_xlati15.xz = ~(u_xlati23.xy);
					                    u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                    u_xlat35 = u_xlat2.x + u_xlat6.x;
					                    u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                    u_xlat35 = u_xlat13 + u_xlat6.z;
					                    u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                    if(u_xlati15.x != 0) {
					                        if(u_xlati23.x == 0) {
					                            u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                        } else {
					                            u_xlat7.x = u_xlat4.y;
					                        }
					                        if(u_xlati23.y == 0) {
					                            u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                        }
					                        u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                        u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                        u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                        u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                        u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                        u_xlat15 = (-u_xlat2.x) * 1.5 + u_xlat5.x;
					                        u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                        u_xlat15 = (-u_xlat13) * 1.5 + u_xlat5.z;
					                        u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                        u_xlati15.xz = ~(u_xlati23.xy);
					                        u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                        u_xlat35 = u_xlat2.x * 1.5 + u_xlat6.x;
					                        u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                        u_xlat35 = u_xlat13 * 1.5 + u_xlat6.z;
					                        u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                        if(u_xlati15.x != 0) {
					                            if(u_xlati23.x == 0) {
					                                u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                            } else {
					                                u_xlat7.x = u_xlat4.y;
					                            }
					                            if(u_xlati23.y == 0) {
					                                u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                            }
					                            u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                            u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                            u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                            u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                            u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                            u_xlat15 = (-u_xlat2.x) * 2.0 + u_xlat5.x;
					                            u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                            u_xlat15 = (-u_xlat13) * 2.0 + u_xlat5.z;
					                            u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                            u_xlati15.xz = ~(u_xlati23.xy);
					                            u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                            u_xlat35 = u_xlat2.x * 2.0 + u_xlat6.x;
					                            u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                            u_xlat35 = u_xlat13 * 2.0 + u_xlat6.z;
					                            u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                            if(u_xlati15.x != 0) {
					                                if(u_xlati23.x == 0) {
					                                    u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                                } else {
					                                    u_xlat7.x = u_xlat4.y;
					                                }
					                                if(u_xlati23.y == 0) {
					                                    u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                                }
					                                u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                                u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                                u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                                u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                                u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                                u_xlat15 = (-u_xlat2.x) * 2.0 + u_xlat5.x;
					                                u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                                u_xlat15 = (-u_xlat13) * 2.0 + u_xlat5.z;
					                                u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                                u_xlati15.xz = ~(u_xlati23.xy);
					                                u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                                u_xlat35 = u_xlat2.x * 2.0 + u_xlat6.x;
					                                u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                                u_xlat35 = u_xlat13 * 2.0 + u_xlat6.z;
					                                u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                                if(u_xlati15.x != 0) {
					                                    if(u_xlati23.x == 0) {
					                                        u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                                    } else {
					                                        u_xlat7.x = u_xlat4.y;
					                                    }
					                                    if(u_xlati23.y == 0) {
					                                        u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                                    }
					                                    u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                                    u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                                    u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                                    u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                                    u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                                    u_xlat15 = (-u_xlat2.x) * 2.0 + u_xlat5.x;
					                                    u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                                    u_xlat15 = (-u_xlat13) * 2.0 + u_xlat5.z;
					                                    u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                                    u_xlati15.xz = ~(u_xlati23.xy);
					                                    u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                                    u_xlat35 = u_xlat2.x * 2.0 + u_xlat6.x;
					                                    u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                                    u_xlat35 = u_xlat13 * 2.0 + u_xlat6.z;
					                                    u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                                    if(u_xlati15.x != 0) {
					                                        if(u_xlati23.x == 0) {
					                                            u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                                        } else {
					                                            u_xlat7.x = u_xlat4.y;
					                                        }
					                                        if(u_xlati23.y == 0) {
					                                            u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                                        }
					                                        u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                                        u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                                        u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                                        u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                                        u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                                        u_xlat15 = (-u_xlat2.x) * 2.0 + u_xlat5.x;
					                                        u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                                        u_xlat15 = (-u_xlat13) * 2.0 + u_xlat5.z;
					                                        u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                                        u_xlati15.xz = ~(u_xlati23.xy);
					                                        u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                                        u_xlat35 = u_xlat2.x * 2.0 + u_xlat6.x;
					                                        u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                                        u_xlat35 = u_xlat13 * 2.0 + u_xlat6.z;
					                                        u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                                        if(u_xlati15.x != 0) {
					                                            if(u_xlati23.x == 0) {
					                                                u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                                            } else {
					                                                u_xlat7.x = u_xlat4.y;
					                                            }
					                                            if(u_xlati23.y == 0) {
					                                                u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                                            }
					                                            u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                                            u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                                            u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                                            u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                                            u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                                            u_xlat15 = (-u_xlat2.x) * 4.0 + u_xlat5.x;
					                                            u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                                            u_xlat15 = (-u_xlat13) * 4.0 + u_xlat5.z;
					                                            u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                                            u_xlati15.xz = ~(u_xlati23.xy);
					                                            u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                                            u_xlat35 = u_xlat2.x * 4.0 + u_xlat6.x;
					                                            u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                                            u_xlat35 = u_xlat13 * 4.0 + u_xlat6.z;
					                                            u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                                            if(u_xlati15.x != 0) {
					                                                if(u_xlati23.x == 0) {
					                                                    u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                                                } else {
					                                                    u_xlat7.x = u_xlat4.y;
					                                                }
					                                                if(u_xlati23.y == 0) {
					                                                    u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                                                }
					                                                u_xlat24 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                                                u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat24;
					                                                u_xlat12.x = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                                                u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat12.x;
					                                                u_xlatb12.xy = greaterThanEqual(abs(u_xlat4.yxyy), vec4(u_xlat22)).xy;
					                                                u_xlat23 = (-u_xlat2.x) * 8.0 + u_xlat5.x;
					                                                u_xlat5.x = (u_xlatb12.x) ? u_xlat5.x : u_xlat23;
					                                                u_xlat23 = (-u_xlat13) * 8.0 + u_xlat5.z;
					                                                u_xlat5.z = (u_xlatb12.x) ? u_xlat5.z : u_xlat23;
					                                                u_xlat2.x = u_xlat2.x * 8.0 + u_xlat6.x;
					                                                u_xlat6.x = (u_xlatb12.y) ? u_xlat6.x : u_xlat2.x;
					                                                u_xlat2.x = u_xlat13 * 8.0 + u_xlat6.z;
					                                                u_xlat6.z = (u_xlatb12.y) ? u_xlat6.z : u_xlat2.x;
					                                            }
					                                        }
					                                    }
					                                }
					                            }
					                        }
					                    }
					                }
					            }
					        }
					        u_xlat2.xz = u_xlat0.xy + (-u_xlat5.xz);
					        u_xlat2.x = (u_xlatb30) ? u_xlat2.x : u_xlat2.z;
					        u_xlat12.xy = (-u_xlat0.xy) + u_xlat6.xz;
					        u_xlat12.x = (u_xlatb30) ? u_xlat12.x : u_xlat12.y;
					        u_xlati13.xy = ivec2(uvec2(lessThan(u_xlat4.yxyy, vec4(0.0, 0.0, 0.0, 0.0)).xy) * 0xFFFFFFFFu);
					        u_xlat22 = u_xlat2.x + u_xlat12.x;
					        u_xlatb3.xy = notEqual(ivec4(u_xlati3), u_xlati13.xyxx).xy;
					        u_xlat22 = float(1.0) / u_xlat22;
					        u_xlatb23 = u_xlat2.x<u_xlat12.x;
					        u_xlat2.x = min(u_xlat12.x, u_xlat2.x);
					        u_xlatb12.x = (u_xlatb23) ? u_xlatb3.x : u_xlatb3.y;
					        u_xlat20 = u_xlat20 * u_xlat20;
					        u_xlat2.x = u_xlat2.x * (-u_xlat22) + 0.5;
					        u_xlat20 = u_xlat20 * _QualitySettings.x;
					        u_xlat2.x = u_xlatb12.x ? u_xlat2.x : float(0.0);
					        u_xlat20 = max(u_xlat20, u_xlat2.x);
					        u_xlat2.xy = vec2(u_xlat20) * vec2(u_xlat32) + u_xlat0.xy;
					        u_xlat3.x = (u_xlatb30) ? u_xlat0.x : u_xlat2.x;
					        u_xlat3.y = (u_xlatb30) ? u_xlat2.y : u_xlat0.y;
					        u_xlat1 = textureLod(_MainTex, u_xlat3.xy, 0.0);
					    }
					    SV_Target0.xyz = u_xlat1.xyz;
					    SV_Target0.w = 1.0;
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "DITHERING" }
					"ps_4_0
					
					#version 330
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
					layout(std140) uniform PGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 _MainTex_ST;
						vec4 unused_0_3[2];
						vec4 _DitheringCoords;
						vec3 _QualitySettings;
						vec4 unused_0_6;
					};
					uniform  sampler2D _MainTex;
					uniform  sampler2D _DitheringTex;
					in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					int u_xlati3;
					bvec2 u_xlatb3;
					vec4 u_xlat4;
					vec4 u_xlat5;
					vec4 u_xlat6;
					vec4 u_xlat7;
					vec4 u_xlat8;
					vec4 u_xlat9;
					float u_xlat10;
					int u_xlati10;
					vec2 u_xlat12;
					bvec2 u_xlatb12;
					float u_xlat13;
					ivec2 u_xlati13;
					float u_xlat15;
					ivec3 u_xlati15;
					float u_xlat20;
					int u_xlati20;
					float u_xlat22;
					float u_xlat23;
					ivec2 u_xlati23;
					bool u_xlatb23;
					float u_xlat24;
					float u_xlat25;
					float u_xlat30;
					bool u_xlatb30;
					float u_xlat32;
					float u_xlat33;
					float u_xlat35;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    u_xlat1 = textureLod(_MainTex, u_xlat0.xy, 0.0);
					    u_xlat2 = _MainTex_TexelSize.xyxy * vec4(0.0, 1.0, 1.0, 0.0) + u_xlat0.xyxy;
					    u_xlat3 = textureLod(_MainTex, u_xlat2.xy, 0.0);
					    u_xlat2 = textureLod(_MainTex, u_xlat2.zw, 0.0);
					    u_xlat4 = _MainTex_TexelSize.xyxy * vec4(0.0, -1.0, -1.0, 0.0) + u_xlat0.xyxy;
					    u_xlat5 = textureLod(_MainTex, u_xlat4.xy, 0.0);
					    u_xlat4 = textureLod(_MainTex, u_xlat4.zw, 0.0);
					    u_xlat20 = max(u_xlat1.y, u_xlat3.y);
					    u_xlat30 = min(u_xlat1.y, u_xlat3.y);
					    u_xlat20 = max(u_xlat20, u_xlat2.y);
					    u_xlat30 = min(u_xlat30, u_xlat2.y);
					    u_xlat2.x = max(u_xlat4.y, u_xlat5.y);
					    u_xlat22 = min(u_xlat4.y, u_xlat5.y);
					    u_xlat20 = max(u_xlat20, u_xlat2.x);
					    u_xlat30 = min(u_xlat30, u_xlat22);
					    u_xlat2.x = u_xlat20 * _QualitySettings.y;
					    u_xlat20 = (-u_xlat30) + u_xlat20;
					    u_xlat30 = max(u_xlat2.x, _QualitySettings.z);
					    u_xlatb30 = u_xlat20>=u_xlat30;
					    if(u_xlatb30){
					        u_xlat2.xz = u_xlat0.xy + (-_MainTex_TexelSize.xy);
					        u_xlat6 = textureLod(_MainTex, u_xlat2.xz, 0.0);
					        u_xlat2.xz = u_xlat0.xy + _MainTex_TexelSize.xy;
					        u_xlat7 = textureLod(_MainTex, u_xlat2.xz, 0.0);
					        u_xlat8 = _MainTex_TexelSize.xyxy * vec4(1.0, -1.0, -1.0, 1.0) + u_xlat0.xyxy;
					        u_xlat9 = textureLod(_MainTex, u_xlat8.xy, 0.0);
					        u_xlat8 = textureLod(_MainTex, u_xlat8.zw, 0.0);
					        u_xlat30 = u_xlat3.y + u_xlat5.y;
					        u_xlat2.x = u_xlat2.y + u_xlat4.y;
					        u_xlat20 = float(1.0) / u_xlat20;
					        u_xlat22 = u_xlat30 + u_xlat2.x;
					        u_xlat30 = u_xlat1.y * -2.0 + u_xlat30;
					        u_xlat2.x = u_xlat1.y * -2.0 + u_xlat2.x;
					        u_xlat32 = u_xlat7.y + u_xlat9.y;
					        u_xlat3.x = u_xlat6.y + u_xlat9.y;
					        u_xlat23 = u_xlat2.y * -2.0 + u_xlat32;
					        u_xlat3.x = u_xlat5.y * -2.0 + u_xlat3.x;
					        u_xlat33 = u_xlat6.y + u_xlat8.y;
					        u_xlat4.x = u_xlat7.y + u_xlat8.y;
					        u_xlat30 = abs(u_xlat30) * 2.0 + abs(u_xlat23);
					        u_xlat2.x = abs(u_xlat2.x) * 2.0 + abs(u_xlat3.x);
					        u_xlat3.x = u_xlat4.y * -2.0 + u_xlat33;
					        u_xlat23 = u_xlat3.y * -2.0 + u_xlat4.x;
					        u_xlat30 = u_xlat30 + abs(u_xlat3.x);
					        u_xlat2.x = u_xlat2.x + abs(u_xlat23);
					        u_xlat32 = u_xlat32 + u_xlat33;
					        u_xlatb30 = u_xlat30>=u_xlat2.x;
					        u_xlat2.x = u_xlat22 * 2.0 + u_xlat32;
					        u_xlat12.y = (u_xlatb30) ? u_xlat5.y : u_xlat4.y;
					        u_xlat12.x = (u_xlatb30) ? u_xlat3.y : u_xlat2.y;
					        u_xlat32 = (u_xlatb30) ? _MainTex_TexelSize.y : _MainTex_TexelSize.x;
					        u_xlat2.x = u_xlat2.x * 0.0833333358 + (-u_xlat1.y);
					        u_xlat3.xy = (-u_xlat1.yy) + u_xlat12.yx;
					        u_xlat12.xy = u_xlat1.yy + u_xlat12.xy;
					        u_xlatb23 = abs(u_xlat3.x)>=abs(u_xlat3.y);
					        u_xlat3.x = max(abs(u_xlat3.y), abs(u_xlat3.x));
					        u_xlat32 = (u_xlatb23) ? (-u_xlat32) : u_xlat32;
					        u_xlat20 = u_xlat20 * abs(u_xlat2.x);
					        u_xlat20 = clamp(u_xlat20, 0.0, 1.0);
					        u_xlat2.x = u_xlatb30 ? _MainTex_TexelSize.x : float(0.0);
					        u_xlat13 = (u_xlatb30) ? 0.0 : _MainTex_TexelSize.y;
					        u_xlat4.xy = vec2(u_xlat32) * vec2(0.5, 0.5) + u_xlat0.xy;
					        u_xlat33 = (u_xlatb30) ? u_xlat0.x : u_xlat4.x;
					        u_xlat4.x = (u_xlatb30) ? u_xlat4.y : u_xlat0.y;
					        u_xlat5.x = (-u_xlat2.x) + u_xlat33;
					        u_xlat5.y = (-u_xlat13) + u_xlat4.x;
					        u_xlat6.x = u_xlat2.x + u_xlat33;
					        u_xlat6.y = u_xlat13 + u_xlat4.x;
					        u_xlat33 = u_xlat20 * -2.0 + 3.0;
					        u_xlat4 = textureLod(_MainTex, u_xlat5.xy, 0.0);
					        u_xlat20 = u_xlat20 * u_xlat20;
					        u_xlat7 = textureLod(_MainTex, u_xlat6.xy, 0.0);
					        u_xlat12.x = (u_xlatb23) ? u_xlat12.y : u_xlat12.x;
					        u_xlat22 = u_xlat3.x * 0.25;
					        u_xlat3.x = (-u_xlat12.x) * 0.5 + u_xlat1.y;
					        u_xlat20 = u_xlat20 * u_xlat33;
					        u_xlati3 = int((u_xlat3.x<0.0) ? 0xFFFFFFFFu : uint(0));
					        u_xlat4.y = (-u_xlat12.x) * 0.5 + u_xlat4.y;
					        u_xlat4.x = (-u_xlat12.x) * 0.5 + u_xlat7.y;
					        u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					        u_xlat25 = (-u_xlat2.x) + u_xlat5.x;
					        u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat25;
					        u_xlat35 = (-u_xlat13) + u_xlat5.y;
					        u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.y : u_xlat35;
					        u_xlati15.xz = ~(u_xlati23.xy);
					        u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					        u_xlat35 = u_xlat2.x + u_xlat6.x;
					        u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					        u_xlat35 = u_xlat13 + u_xlat6.y;
					        u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.y : u_xlat35;
					        if(u_xlati15.x != 0) {
					            if(u_xlati23.x == 0) {
					                u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					            } else {
					                u_xlat7.x = u_xlat4.y;
					            }
					            if(u_xlati23.y == 0) {
					                u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					            }
					            u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					            u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					            u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					            u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					            u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					            u_xlat15 = (-u_xlat2.x) + u_xlat5.x;
					            u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					            u_xlat15 = (-u_xlat13) + u_xlat5.z;
					            u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					            u_xlati15.xz = ~(u_xlati23.xy);
					            u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					            u_xlat35 = u_xlat2.x + u_xlat6.x;
					            u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					            u_xlat35 = u_xlat13 + u_xlat6.z;
					            u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					            if(u_xlati15.x != 0) {
					                if(u_xlati23.x == 0) {
					                    u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                } else {
					                    u_xlat7.x = u_xlat4.y;
					                }
					                if(u_xlati23.y == 0) {
					                    u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                }
					                u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                u_xlat15 = (-u_xlat2.x) + u_xlat5.x;
					                u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                u_xlat15 = (-u_xlat13) + u_xlat5.z;
					                u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                u_xlati15.xz = ~(u_xlati23.xy);
					                u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                u_xlat35 = u_xlat2.x + u_xlat6.x;
					                u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                u_xlat35 = u_xlat13 + u_xlat6.z;
					                u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                if(u_xlati15.x != 0) {
					                    if(u_xlati23.x == 0) {
					                        u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                    } else {
					                        u_xlat7.x = u_xlat4.y;
					                    }
					                    if(u_xlati23.y == 0) {
					                        u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                    }
					                    u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                    u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                    u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                    u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                    u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                    u_xlat15 = (-u_xlat2.x) + u_xlat5.x;
					                    u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                    u_xlat15 = (-u_xlat13) + u_xlat5.z;
					                    u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                    u_xlati15.xz = ~(u_xlati23.xy);
					                    u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                    u_xlat35 = u_xlat2.x + u_xlat6.x;
					                    u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                    u_xlat35 = u_xlat13 + u_xlat6.z;
					                    u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                    if(u_xlati15.x != 0) {
					                        if(u_xlati23.x == 0) {
					                            u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                        } else {
					                            u_xlat7.x = u_xlat4.y;
					                        }
					                        if(u_xlati23.y == 0) {
					                            u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                        }
					                        u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                        u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                        u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                        u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                        u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                        u_xlat15 = (-u_xlat2.x) * 1.5 + u_xlat5.x;
					                        u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                        u_xlat15 = (-u_xlat13) * 1.5 + u_xlat5.z;
					                        u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                        u_xlati15.xz = ~(u_xlati23.xy);
					                        u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                        u_xlat35 = u_xlat2.x * 1.5 + u_xlat6.x;
					                        u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                        u_xlat35 = u_xlat13 * 1.5 + u_xlat6.z;
					                        u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                        if(u_xlati15.x != 0) {
					                            if(u_xlati23.x == 0) {
					                                u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                            } else {
					                                u_xlat7.x = u_xlat4.y;
					                            }
					                            if(u_xlati23.y == 0) {
					                                u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                            }
					                            u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                            u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                            u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                            u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                            u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                            u_xlat15 = (-u_xlat2.x) * 2.0 + u_xlat5.x;
					                            u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                            u_xlat15 = (-u_xlat13) * 2.0 + u_xlat5.z;
					                            u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                            u_xlati15.xz = ~(u_xlati23.xy);
					                            u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                            u_xlat35 = u_xlat2.x * 2.0 + u_xlat6.x;
					                            u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                            u_xlat35 = u_xlat13 * 2.0 + u_xlat6.z;
					                            u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                            if(u_xlati15.x != 0) {
					                                if(u_xlati23.x == 0) {
					                                    u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                                } else {
					                                    u_xlat7.x = u_xlat4.y;
					                                }
					                                if(u_xlati23.y == 0) {
					                                    u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                                }
					                                u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                                u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                                u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                                u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                                u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                                u_xlat15 = (-u_xlat2.x) * 2.0 + u_xlat5.x;
					                                u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                                u_xlat15 = (-u_xlat13) * 2.0 + u_xlat5.z;
					                                u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                                u_xlati15.xz = ~(u_xlati23.xy);
					                                u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                                u_xlat35 = u_xlat2.x * 2.0 + u_xlat6.x;
					                                u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                                u_xlat35 = u_xlat13 * 2.0 + u_xlat6.z;
					                                u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                                if(u_xlati15.x != 0) {
					                                    if(u_xlati23.x == 0) {
					                                        u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                                    } else {
					                                        u_xlat7.x = u_xlat4.y;
					                                    }
					                                    if(u_xlati23.y == 0) {
					                                        u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                                    }
					                                    u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                                    u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                                    u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                                    u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                                    u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                                    u_xlat15 = (-u_xlat2.x) * 2.0 + u_xlat5.x;
					                                    u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                                    u_xlat15 = (-u_xlat13) * 2.0 + u_xlat5.z;
					                                    u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                                    u_xlati15.xz = ~(u_xlati23.xy);
					                                    u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                                    u_xlat35 = u_xlat2.x * 2.0 + u_xlat6.x;
					                                    u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                                    u_xlat35 = u_xlat13 * 2.0 + u_xlat6.z;
					                                    u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                                    if(u_xlati15.x != 0) {
					                                        if(u_xlati23.x == 0) {
					                                            u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                                        } else {
					                                            u_xlat7.x = u_xlat4.y;
					                                        }
					                                        if(u_xlati23.y == 0) {
					                                            u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                                        }
					                                        u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                                        u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                                        u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                                        u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                                        u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                                        u_xlat15 = (-u_xlat2.x) * 2.0 + u_xlat5.x;
					                                        u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                                        u_xlat15 = (-u_xlat13) * 2.0 + u_xlat5.z;
					                                        u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                                        u_xlati15.xz = ~(u_xlati23.xy);
					                                        u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                                        u_xlat35 = u_xlat2.x * 2.0 + u_xlat6.x;
					                                        u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                                        u_xlat35 = u_xlat13 * 2.0 + u_xlat6.z;
					                                        u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                                        if(u_xlati15.x != 0) {
					                                            if(u_xlati23.x == 0) {
					                                                u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                                            } else {
					                                                u_xlat7.x = u_xlat4.y;
					                                            }
					                                            if(u_xlati23.y == 0) {
					                                                u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                                            }
					                                            u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                                            u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                                            u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                                            u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                                            u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                                            u_xlat15 = (-u_xlat2.x) * 4.0 + u_xlat5.x;
					                                            u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                                            u_xlat15 = (-u_xlat13) * 4.0 + u_xlat5.z;
					                                            u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                                            u_xlati15.xz = ~(u_xlati23.xy);
					                                            u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                                            u_xlat35 = u_xlat2.x * 4.0 + u_xlat6.x;
					                                            u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                                            u_xlat35 = u_xlat13 * 4.0 + u_xlat6.z;
					                                            u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                                            if(u_xlati15.x != 0) {
					                                                if(u_xlati23.x == 0) {
					                                                    u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                                                } else {
					                                                    u_xlat7.x = u_xlat4.y;
					                                                }
					                                                if(u_xlati23.y == 0) {
					                                                    u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                                                }
					                                                u_xlat24 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                                                u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat24;
					                                                u_xlat12.x = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                                                u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat12.x;
					                                                u_xlatb12.xy = greaterThanEqual(abs(u_xlat4.yxyy), vec4(u_xlat22)).xy;
					                                                u_xlat23 = (-u_xlat2.x) * 8.0 + u_xlat5.x;
					                                                u_xlat5.x = (u_xlatb12.x) ? u_xlat5.x : u_xlat23;
					                                                u_xlat23 = (-u_xlat13) * 8.0 + u_xlat5.z;
					                                                u_xlat5.z = (u_xlatb12.x) ? u_xlat5.z : u_xlat23;
					                                                u_xlat2.x = u_xlat2.x * 8.0 + u_xlat6.x;
					                                                u_xlat6.x = (u_xlatb12.y) ? u_xlat6.x : u_xlat2.x;
					                                                u_xlat2.x = u_xlat13 * 8.0 + u_xlat6.z;
					                                                u_xlat6.z = (u_xlatb12.y) ? u_xlat6.z : u_xlat2.x;
					                                            }
					                                        }
					                                    }
					                                }
					                            }
					                        }
					                    }
					                }
					            }
					        }
					        u_xlat2.xz = u_xlat0.xy + (-u_xlat5.xz);
					        u_xlat2.x = (u_xlatb30) ? u_xlat2.x : u_xlat2.z;
					        u_xlat12.xy = (-u_xlat0.xy) + u_xlat6.xz;
					        u_xlat12.x = (u_xlatb30) ? u_xlat12.x : u_xlat12.y;
					        u_xlati13.xy = ivec2(uvec2(lessThan(u_xlat4.yxyy, vec4(0.0, 0.0, 0.0, 0.0)).xy) * 0xFFFFFFFFu);
					        u_xlat22 = u_xlat2.x + u_xlat12.x;
					        u_xlatb3.xy = notEqual(ivec4(u_xlati3), u_xlati13.xyxx).xy;
					        u_xlat22 = float(1.0) / u_xlat22;
					        u_xlatb23 = u_xlat2.x<u_xlat12.x;
					        u_xlat2.x = min(u_xlat12.x, u_xlat2.x);
					        u_xlatb12.x = (u_xlatb23) ? u_xlatb3.x : u_xlatb3.y;
					        u_xlat20 = u_xlat20 * u_xlat20;
					        u_xlat2.x = u_xlat2.x * (-u_xlat22) + 0.5;
					        u_xlat20 = u_xlat20 * _QualitySettings.x;
					        u_xlat2.x = u_xlatb12.x ? u_xlat2.x : float(0.0);
					        u_xlat20 = max(u_xlat20, u_xlat2.x);
					        u_xlat2.xy = vec2(u_xlat20) * vec2(u_xlat32) + u_xlat0.xy;
					        u_xlat3.x = (u_xlatb30) ? u_xlat0.x : u_xlat2.x;
					        u_xlat3.y = (u_xlatb30) ? u_xlat2.y : u_xlat0.y;
					        u_xlat1 = textureLod(_MainTex, u_xlat3.xy, 0.0);
					    }
					    u_xlat0.xy = vs_TEXCOORD0.xy * _DitheringCoords.xy + _DitheringCoords.zw;
					    u_xlat0 = texture(_DitheringTex, u_xlat0.xy);
					    u_xlat0.x = u_xlat0.w * 2.0 + -1.0;
					    u_xlati10 = int((0.0<u_xlat0.x) ? 0xFFFFFFFFu : uint(0));
					    u_xlati20 = int((u_xlat0.x<0.0) ? 0xFFFFFFFFu : uint(0));
					    u_xlati10 = (-u_xlati10) + u_xlati20;
					    u_xlat10 = float(u_xlati10);
					    u_xlat0.x = -abs(u_xlat0.x) + 1.0;
					    u_xlat0.x = sqrt(u_xlat0.x);
					    u_xlat0.x = (-u_xlat0.x) + 1.0;
					    u_xlat0.x = u_xlat0.x * u_xlat10;
					    SV_Target0.xyz = u_xlat0.xxx * vec3(0.00392156886, 0.00392156886, 0.00392156886) + u_xlat1.xyz;
					    SV_Target0.w = 1.0;
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "GRAIN" }
					"ps_4_0
					
					#version 330
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
					layout(std140) uniform PGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 _MainTex_ST;
						vec2 _Grain_Params1;
						vec4 _Grain_Params2;
						vec4 unused_0_5;
						vec3 _QualitySettings;
						vec4 unused_0_7;
					};
					uniform  sampler2D _MainTex;
					uniform  sampler2D _GrainTex;
					in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					int u_xlati3;
					bvec2 u_xlatb3;
					vec4 u_xlat4;
					vec4 u_xlat5;
					vec4 u_xlat6;
					vec4 u_xlat7;
					vec4 u_xlat8;
					vec4 u_xlat9;
					vec2 u_xlat12;
					bvec2 u_xlatb12;
					float u_xlat13;
					ivec2 u_xlati13;
					float u_xlat15;
					ivec3 u_xlati15;
					float u_xlat20;
					float u_xlat22;
					float u_xlat23;
					ivec2 u_xlati23;
					bool u_xlatb23;
					float u_xlat24;
					float u_xlat25;
					float u_xlat30;
					bool u_xlatb30;
					float u_xlat32;
					float u_xlat33;
					float u_xlat35;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    u_xlat1 = textureLod(_MainTex, u_xlat0.xy, 0.0);
					    u_xlat2 = _MainTex_TexelSize.xyxy * vec4(0.0, 1.0, 1.0, 0.0) + u_xlat0.xyxy;
					    u_xlat3 = textureLod(_MainTex, u_xlat2.xy, 0.0);
					    u_xlat2 = textureLod(_MainTex, u_xlat2.zw, 0.0);
					    u_xlat4 = _MainTex_TexelSize.xyxy * vec4(0.0, -1.0, -1.0, 0.0) + u_xlat0.xyxy;
					    u_xlat5 = textureLod(_MainTex, u_xlat4.xy, 0.0);
					    u_xlat4 = textureLod(_MainTex, u_xlat4.zw, 0.0);
					    u_xlat20 = max(u_xlat1.y, u_xlat3.y);
					    u_xlat30 = min(u_xlat1.y, u_xlat3.y);
					    u_xlat20 = max(u_xlat20, u_xlat2.y);
					    u_xlat30 = min(u_xlat30, u_xlat2.y);
					    u_xlat2.x = max(u_xlat4.y, u_xlat5.y);
					    u_xlat22 = min(u_xlat4.y, u_xlat5.y);
					    u_xlat20 = max(u_xlat20, u_xlat2.x);
					    u_xlat30 = min(u_xlat30, u_xlat22);
					    u_xlat2.x = u_xlat20 * _QualitySettings.y;
					    u_xlat20 = (-u_xlat30) + u_xlat20;
					    u_xlat30 = max(u_xlat2.x, _QualitySettings.z);
					    u_xlatb30 = u_xlat20>=u_xlat30;
					    if(u_xlatb30){
					        u_xlat2.xz = u_xlat0.xy + (-_MainTex_TexelSize.xy);
					        u_xlat6 = textureLod(_MainTex, u_xlat2.xz, 0.0);
					        u_xlat2.xz = u_xlat0.xy + _MainTex_TexelSize.xy;
					        u_xlat7 = textureLod(_MainTex, u_xlat2.xz, 0.0);
					        u_xlat8 = _MainTex_TexelSize.xyxy * vec4(1.0, -1.0, -1.0, 1.0) + u_xlat0.xyxy;
					        u_xlat9 = textureLod(_MainTex, u_xlat8.xy, 0.0);
					        u_xlat8 = textureLod(_MainTex, u_xlat8.zw, 0.0);
					        u_xlat30 = u_xlat3.y + u_xlat5.y;
					        u_xlat2.x = u_xlat2.y + u_xlat4.y;
					        u_xlat20 = float(1.0) / u_xlat20;
					        u_xlat22 = u_xlat30 + u_xlat2.x;
					        u_xlat30 = u_xlat1.y * -2.0 + u_xlat30;
					        u_xlat2.x = u_xlat1.y * -2.0 + u_xlat2.x;
					        u_xlat32 = u_xlat7.y + u_xlat9.y;
					        u_xlat3.x = u_xlat6.y + u_xlat9.y;
					        u_xlat23 = u_xlat2.y * -2.0 + u_xlat32;
					        u_xlat3.x = u_xlat5.y * -2.0 + u_xlat3.x;
					        u_xlat33 = u_xlat6.y + u_xlat8.y;
					        u_xlat4.x = u_xlat7.y + u_xlat8.y;
					        u_xlat30 = abs(u_xlat30) * 2.0 + abs(u_xlat23);
					        u_xlat2.x = abs(u_xlat2.x) * 2.0 + abs(u_xlat3.x);
					        u_xlat3.x = u_xlat4.y * -2.0 + u_xlat33;
					        u_xlat23 = u_xlat3.y * -2.0 + u_xlat4.x;
					        u_xlat30 = u_xlat30 + abs(u_xlat3.x);
					        u_xlat2.x = u_xlat2.x + abs(u_xlat23);
					        u_xlat32 = u_xlat32 + u_xlat33;
					        u_xlatb30 = u_xlat30>=u_xlat2.x;
					        u_xlat2.x = u_xlat22 * 2.0 + u_xlat32;
					        u_xlat12.y = (u_xlatb30) ? u_xlat5.y : u_xlat4.y;
					        u_xlat12.x = (u_xlatb30) ? u_xlat3.y : u_xlat2.y;
					        u_xlat32 = (u_xlatb30) ? _MainTex_TexelSize.y : _MainTex_TexelSize.x;
					        u_xlat2.x = u_xlat2.x * 0.0833333358 + (-u_xlat1.y);
					        u_xlat3.xy = (-u_xlat1.yy) + u_xlat12.yx;
					        u_xlat12.xy = u_xlat1.yy + u_xlat12.xy;
					        u_xlatb23 = abs(u_xlat3.x)>=abs(u_xlat3.y);
					        u_xlat3.x = max(abs(u_xlat3.y), abs(u_xlat3.x));
					        u_xlat32 = (u_xlatb23) ? (-u_xlat32) : u_xlat32;
					        u_xlat20 = u_xlat20 * abs(u_xlat2.x);
					        u_xlat20 = clamp(u_xlat20, 0.0, 1.0);
					        u_xlat2.x = u_xlatb30 ? _MainTex_TexelSize.x : float(0.0);
					        u_xlat13 = (u_xlatb30) ? 0.0 : _MainTex_TexelSize.y;
					        u_xlat4.xy = vec2(u_xlat32) * vec2(0.5, 0.5) + u_xlat0.xy;
					        u_xlat33 = (u_xlatb30) ? u_xlat0.x : u_xlat4.x;
					        u_xlat4.x = (u_xlatb30) ? u_xlat4.y : u_xlat0.y;
					        u_xlat5.x = (-u_xlat2.x) + u_xlat33;
					        u_xlat5.y = (-u_xlat13) + u_xlat4.x;
					        u_xlat6.x = u_xlat2.x + u_xlat33;
					        u_xlat6.y = u_xlat13 + u_xlat4.x;
					        u_xlat33 = u_xlat20 * -2.0 + 3.0;
					        u_xlat4 = textureLod(_MainTex, u_xlat5.xy, 0.0);
					        u_xlat20 = u_xlat20 * u_xlat20;
					        u_xlat7 = textureLod(_MainTex, u_xlat6.xy, 0.0);
					        u_xlat12.x = (u_xlatb23) ? u_xlat12.y : u_xlat12.x;
					        u_xlat22 = u_xlat3.x * 0.25;
					        u_xlat3.x = (-u_xlat12.x) * 0.5 + u_xlat1.y;
					        u_xlat20 = u_xlat20 * u_xlat33;
					        u_xlati3 = int((u_xlat3.x<0.0) ? 0xFFFFFFFFu : uint(0));
					        u_xlat4.y = (-u_xlat12.x) * 0.5 + u_xlat4.y;
					        u_xlat4.x = (-u_xlat12.x) * 0.5 + u_xlat7.y;
					        u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					        u_xlat25 = (-u_xlat2.x) + u_xlat5.x;
					        u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat25;
					        u_xlat35 = (-u_xlat13) + u_xlat5.y;
					        u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.y : u_xlat35;
					        u_xlati15.xz = ~(u_xlati23.xy);
					        u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					        u_xlat35 = u_xlat2.x + u_xlat6.x;
					        u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					        u_xlat35 = u_xlat13 + u_xlat6.y;
					        u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.y : u_xlat35;
					        if(u_xlati15.x != 0) {
					            if(u_xlati23.x == 0) {
					                u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					            } else {
					                u_xlat7.x = u_xlat4.y;
					            }
					            if(u_xlati23.y == 0) {
					                u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					            }
					            u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					            u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					            u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					            u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					            u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					            u_xlat15 = (-u_xlat2.x) + u_xlat5.x;
					            u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					            u_xlat15 = (-u_xlat13) + u_xlat5.z;
					            u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					            u_xlati15.xz = ~(u_xlati23.xy);
					            u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					            u_xlat35 = u_xlat2.x + u_xlat6.x;
					            u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					            u_xlat35 = u_xlat13 + u_xlat6.z;
					            u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					            if(u_xlati15.x != 0) {
					                if(u_xlati23.x == 0) {
					                    u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                } else {
					                    u_xlat7.x = u_xlat4.y;
					                }
					                if(u_xlati23.y == 0) {
					                    u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                }
					                u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                u_xlat15 = (-u_xlat2.x) + u_xlat5.x;
					                u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                u_xlat15 = (-u_xlat13) + u_xlat5.z;
					                u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                u_xlati15.xz = ~(u_xlati23.xy);
					                u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                u_xlat35 = u_xlat2.x + u_xlat6.x;
					                u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                u_xlat35 = u_xlat13 + u_xlat6.z;
					                u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                if(u_xlati15.x != 0) {
					                    if(u_xlati23.x == 0) {
					                        u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                    } else {
					                        u_xlat7.x = u_xlat4.y;
					                    }
					                    if(u_xlati23.y == 0) {
					                        u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                    }
					                    u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                    u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                    u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                    u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                    u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                    u_xlat15 = (-u_xlat2.x) + u_xlat5.x;
					                    u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                    u_xlat15 = (-u_xlat13) + u_xlat5.z;
					                    u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                    u_xlati15.xz = ~(u_xlati23.xy);
					                    u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                    u_xlat35 = u_xlat2.x + u_xlat6.x;
					                    u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                    u_xlat35 = u_xlat13 + u_xlat6.z;
					                    u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                    if(u_xlati15.x != 0) {
					                        if(u_xlati23.x == 0) {
					                            u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                        } else {
					                            u_xlat7.x = u_xlat4.y;
					                        }
					                        if(u_xlati23.y == 0) {
					                            u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                        }
					                        u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                        u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                        u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                        u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                        u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                        u_xlat15 = (-u_xlat2.x) * 1.5 + u_xlat5.x;
					                        u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                        u_xlat15 = (-u_xlat13) * 1.5 + u_xlat5.z;
					                        u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                        u_xlati15.xz = ~(u_xlati23.xy);
					                        u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                        u_xlat35 = u_xlat2.x * 1.5 + u_xlat6.x;
					                        u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                        u_xlat35 = u_xlat13 * 1.5 + u_xlat6.z;
					                        u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                        if(u_xlati15.x != 0) {
					                            if(u_xlati23.x == 0) {
					                                u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                            } else {
					                                u_xlat7.x = u_xlat4.y;
					                            }
					                            if(u_xlati23.y == 0) {
					                                u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                            }
					                            u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                            u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                            u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                            u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                            u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                            u_xlat15 = (-u_xlat2.x) * 2.0 + u_xlat5.x;
					                            u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                            u_xlat15 = (-u_xlat13) * 2.0 + u_xlat5.z;
					                            u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                            u_xlati15.xz = ~(u_xlati23.xy);
					                            u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                            u_xlat35 = u_xlat2.x * 2.0 + u_xlat6.x;
					                            u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                            u_xlat35 = u_xlat13 * 2.0 + u_xlat6.z;
					                            u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                            if(u_xlati15.x != 0) {
					                                if(u_xlati23.x == 0) {
					                                    u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                                } else {
					                                    u_xlat7.x = u_xlat4.y;
					                                }
					                                if(u_xlati23.y == 0) {
					                                    u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                                }
					                                u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                                u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                                u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                                u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                                u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                                u_xlat15 = (-u_xlat2.x) * 2.0 + u_xlat5.x;
					                                u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                                u_xlat15 = (-u_xlat13) * 2.0 + u_xlat5.z;
					                                u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                                u_xlati15.xz = ~(u_xlati23.xy);
					                                u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                                u_xlat35 = u_xlat2.x * 2.0 + u_xlat6.x;
					                                u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                                u_xlat35 = u_xlat13 * 2.0 + u_xlat6.z;
					                                u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                                if(u_xlati15.x != 0) {
					                                    if(u_xlati23.x == 0) {
					                                        u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                                    } else {
					                                        u_xlat7.x = u_xlat4.y;
					                                    }
					                                    if(u_xlati23.y == 0) {
					                                        u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                                    }
					                                    u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                                    u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                                    u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                                    u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                                    u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                                    u_xlat15 = (-u_xlat2.x) * 2.0 + u_xlat5.x;
					                                    u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                                    u_xlat15 = (-u_xlat13) * 2.0 + u_xlat5.z;
					                                    u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                                    u_xlati15.xz = ~(u_xlati23.xy);
					                                    u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                                    u_xlat35 = u_xlat2.x * 2.0 + u_xlat6.x;
					                                    u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                                    u_xlat35 = u_xlat13 * 2.0 + u_xlat6.z;
					                                    u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                                    if(u_xlati15.x != 0) {
					                                        if(u_xlati23.x == 0) {
					                                            u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                                        } else {
					                                            u_xlat7.x = u_xlat4.y;
					                                        }
					                                        if(u_xlati23.y == 0) {
					                                            u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                                        }
					                                        u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                                        u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                                        u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                                        u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                                        u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                                        u_xlat15 = (-u_xlat2.x) * 2.0 + u_xlat5.x;
					                                        u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                                        u_xlat15 = (-u_xlat13) * 2.0 + u_xlat5.z;
					                                        u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                                        u_xlati15.xz = ~(u_xlati23.xy);
					                                        u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                                        u_xlat35 = u_xlat2.x * 2.0 + u_xlat6.x;
					                                        u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                                        u_xlat35 = u_xlat13 * 2.0 + u_xlat6.z;
					                                        u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                                        if(u_xlati15.x != 0) {
					                                            if(u_xlati23.x == 0) {
					                                                u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                                            } else {
					                                                u_xlat7.x = u_xlat4.y;
					                                            }
					                                            if(u_xlati23.y == 0) {
					                                                u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                                            }
					                                            u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                                            u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                                            u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                                            u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                                            u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                                            u_xlat15 = (-u_xlat2.x) * 4.0 + u_xlat5.x;
					                                            u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                                            u_xlat15 = (-u_xlat13) * 4.0 + u_xlat5.z;
					                                            u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                                            u_xlati15.xz = ~(u_xlati23.xy);
					                                            u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                                            u_xlat35 = u_xlat2.x * 4.0 + u_xlat6.x;
					                                            u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                                            u_xlat35 = u_xlat13 * 4.0 + u_xlat6.z;
					                                            u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                                            if(u_xlati15.x != 0) {
					                                                if(u_xlati23.x == 0) {
					                                                    u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                                                } else {
					                                                    u_xlat7.x = u_xlat4.y;
					                                                }
					                                                if(u_xlati23.y == 0) {
					                                                    u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                                                }
					                                                u_xlat24 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                                                u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat24;
					                                                u_xlat12.x = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                                                u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat12.x;
					                                                u_xlatb12.xy = greaterThanEqual(abs(u_xlat4.yxyy), vec4(u_xlat22)).xy;
					                                                u_xlat23 = (-u_xlat2.x) * 8.0 + u_xlat5.x;
					                                                u_xlat5.x = (u_xlatb12.x) ? u_xlat5.x : u_xlat23;
					                                                u_xlat23 = (-u_xlat13) * 8.0 + u_xlat5.z;
					                                                u_xlat5.z = (u_xlatb12.x) ? u_xlat5.z : u_xlat23;
					                                                u_xlat2.x = u_xlat2.x * 8.0 + u_xlat6.x;
					                                                u_xlat6.x = (u_xlatb12.y) ? u_xlat6.x : u_xlat2.x;
					                                                u_xlat2.x = u_xlat13 * 8.0 + u_xlat6.z;
					                                                u_xlat6.z = (u_xlatb12.y) ? u_xlat6.z : u_xlat2.x;
					                                            }
					                                        }
					                                    }
					                                }
					                            }
					                        }
					                    }
					                }
					            }
					        }
					        u_xlat2.xz = u_xlat0.xy + (-u_xlat5.xz);
					        u_xlat2.x = (u_xlatb30) ? u_xlat2.x : u_xlat2.z;
					        u_xlat12.xy = (-u_xlat0.xy) + u_xlat6.xz;
					        u_xlat12.x = (u_xlatb30) ? u_xlat12.x : u_xlat12.y;
					        u_xlati13.xy = ivec2(uvec2(lessThan(u_xlat4.yxyy, vec4(0.0, 0.0, 0.0, 0.0)).xy) * 0xFFFFFFFFu);
					        u_xlat22 = u_xlat2.x + u_xlat12.x;
					        u_xlatb3.xy = notEqual(ivec4(u_xlati3), u_xlati13.xyxx).xy;
					        u_xlat22 = float(1.0) / u_xlat22;
					        u_xlatb23 = u_xlat2.x<u_xlat12.x;
					        u_xlat2.x = min(u_xlat12.x, u_xlat2.x);
					        u_xlatb12.x = (u_xlatb23) ? u_xlatb3.x : u_xlatb3.y;
					        u_xlat20 = u_xlat20 * u_xlat20;
					        u_xlat2.x = u_xlat2.x * (-u_xlat22) + 0.5;
					        u_xlat20 = u_xlat20 * _QualitySettings.x;
					        u_xlat2.x = u_xlatb12.x ? u_xlat2.x : float(0.0);
					        u_xlat20 = max(u_xlat20, u_xlat2.x);
					        u_xlat2.xy = vec2(u_xlat20) * vec2(u_xlat32) + u_xlat0.xy;
					        u_xlat3.x = (u_xlatb30) ? u_xlat0.x : u_xlat2.x;
					        u_xlat3.y = (u_xlatb30) ? u_xlat2.y : u_xlat0.y;
					        u_xlat1 = textureLod(_MainTex, u_xlat3.xy, 0.0);
					    }
					    u_xlat0.xy = vs_TEXCOORD0.xy * _Grain_Params2.xy + _Grain_Params2.zw;
					    u_xlat0 = texture(_GrainTex, u_xlat0.xy);
					    u_xlat30 = dot(u_xlat1.xyz, vec3(0.212599993, 0.715200007, 0.0722000003));
					    u_xlat30 = sqrt(u_xlat30);
					    u_xlat30 = _Grain_Params1.x * (-u_xlat30) + 1.0;
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * _Grain_Params1.yyy;
					    SV_Target0.xyz = u_xlat0.xyz * vec3(u_xlat30) + u_xlat1.xyz;
					    SV_Target0.w = 1.0;
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "GRAIN" "DITHERING" }
					"ps_4_0
					
					#version 330
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
					layout(std140) uniform PGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 _MainTex_ST;
						vec2 _Grain_Params1;
						vec4 _Grain_Params2;
						vec4 _DitheringCoords;
						vec3 _QualitySettings;
						vec4 unused_0_7;
					};
					uniform  sampler2D _MainTex;
					uniform  sampler2D _GrainTex;
					uniform  sampler2D _DitheringTex;
					in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					int u_xlati1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					int u_xlati3;
					bvec2 u_xlatb3;
					vec4 u_xlat4;
					vec4 u_xlat5;
					vec4 u_xlat6;
					vec4 u_xlat7;
					vec4 u_xlat8;
					vec4 u_xlat9;
					int u_xlati11;
					vec2 u_xlat12;
					bvec2 u_xlatb12;
					float u_xlat13;
					ivec2 u_xlati13;
					float u_xlat15;
					ivec3 u_xlati15;
					float u_xlat20;
					float u_xlat22;
					float u_xlat23;
					ivec2 u_xlati23;
					bool u_xlatb23;
					float u_xlat24;
					float u_xlat25;
					float u_xlat30;
					bool u_xlatb30;
					float u_xlat32;
					float u_xlat33;
					float u_xlat35;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    u_xlat1 = textureLod(_MainTex, u_xlat0.xy, 0.0);
					    u_xlat2 = _MainTex_TexelSize.xyxy * vec4(0.0, 1.0, 1.0, 0.0) + u_xlat0.xyxy;
					    u_xlat3 = textureLod(_MainTex, u_xlat2.xy, 0.0);
					    u_xlat2 = textureLod(_MainTex, u_xlat2.zw, 0.0);
					    u_xlat4 = _MainTex_TexelSize.xyxy * vec4(0.0, -1.0, -1.0, 0.0) + u_xlat0.xyxy;
					    u_xlat5 = textureLod(_MainTex, u_xlat4.xy, 0.0);
					    u_xlat4 = textureLod(_MainTex, u_xlat4.zw, 0.0);
					    u_xlat20 = max(u_xlat1.y, u_xlat3.y);
					    u_xlat30 = min(u_xlat1.y, u_xlat3.y);
					    u_xlat20 = max(u_xlat20, u_xlat2.y);
					    u_xlat30 = min(u_xlat30, u_xlat2.y);
					    u_xlat2.x = max(u_xlat4.y, u_xlat5.y);
					    u_xlat22 = min(u_xlat4.y, u_xlat5.y);
					    u_xlat20 = max(u_xlat20, u_xlat2.x);
					    u_xlat30 = min(u_xlat30, u_xlat22);
					    u_xlat2.x = u_xlat20 * _QualitySettings.y;
					    u_xlat20 = (-u_xlat30) + u_xlat20;
					    u_xlat30 = max(u_xlat2.x, _QualitySettings.z);
					    u_xlatb30 = u_xlat20>=u_xlat30;
					    if(u_xlatb30){
					        u_xlat2.xz = u_xlat0.xy + (-_MainTex_TexelSize.xy);
					        u_xlat6 = textureLod(_MainTex, u_xlat2.xz, 0.0);
					        u_xlat2.xz = u_xlat0.xy + _MainTex_TexelSize.xy;
					        u_xlat7 = textureLod(_MainTex, u_xlat2.xz, 0.0);
					        u_xlat8 = _MainTex_TexelSize.xyxy * vec4(1.0, -1.0, -1.0, 1.0) + u_xlat0.xyxy;
					        u_xlat9 = textureLod(_MainTex, u_xlat8.xy, 0.0);
					        u_xlat8 = textureLod(_MainTex, u_xlat8.zw, 0.0);
					        u_xlat30 = u_xlat3.y + u_xlat5.y;
					        u_xlat2.x = u_xlat2.y + u_xlat4.y;
					        u_xlat20 = float(1.0) / u_xlat20;
					        u_xlat22 = u_xlat30 + u_xlat2.x;
					        u_xlat30 = u_xlat1.y * -2.0 + u_xlat30;
					        u_xlat2.x = u_xlat1.y * -2.0 + u_xlat2.x;
					        u_xlat32 = u_xlat7.y + u_xlat9.y;
					        u_xlat3.x = u_xlat6.y + u_xlat9.y;
					        u_xlat23 = u_xlat2.y * -2.0 + u_xlat32;
					        u_xlat3.x = u_xlat5.y * -2.0 + u_xlat3.x;
					        u_xlat33 = u_xlat6.y + u_xlat8.y;
					        u_xlat4.x = u_xlat7.y + u_xlat8.y;
					        u_xlat30 = abs(u_xlat30) * 2.0 + abs(u_xlat23);
					        u_xlat2.x = abs(u_xlat2.x) * 2.0 + abs(u_xlat3.x);
					        u_xlat3.x = u_xlat4.y * -2.0 + u_xlat33;
					        u_xlat23 = u_xlat3.y * -2.0 + u_xlat4.x;
					        u_xlat30 = u_xlat30 + abs(u_xlat3.x);
					        u_xlat2.x = u_xlat2.x + abs(u_xlat23);
					        u_xlat32 = u_xlat32 + u_xlat33;
					        u_xlatb30 = u_xlat30>=u_xlat2.x;
					        u_xlat2.x = u_xlat22 * 2.0 + u_xlat32;
					        u_xlat12.y = (u_xlatb30) ? u_xlat5.y : u_xlat4.y;
					        u_xlat12.x = (u_xlatb30) ? u_xlat3.y : u_xlat2.y;
					        u_xlat32 = (u_xlatb30) ? _MainTex_TexelSize.y : _MainTex_TexelSize.x;
					        u_xlat2.x = u_xlat2.x * 0.0833333358 + (-u_xlat1.y);
					        u_xlat3.xy = (-u_xlat1.yy) + u_xlat12.yx;
					        u_xlat12.xy = u_xlat1.yy + u_xlat12.xy;
					        u_xlatb23 = abs(u_xlat3.x)>=abs(u_xlat3.y);
					        u_xlat3.x = max(abs(u_xlat3.y), abs(u_xlat3.x));
					        u_xlat32 = (u_xlatb23) ? (-u_xlat32) : u_xlat32;
					        u_xlat20 = u_xlat20 * abs(u_xlat2.x);
					        u_xlat20 = clamp(u_xlat20, 0.0, 1.0);
					        u_xlat2.x = u_xlatb30 ? _MainTex_TexelSize.x : float(0.0);
					        u_xlat13 = (u_xlatb30) ? 0.0 : _MainTex_TexelSize.y;
					        u_xlat4.xy = vec2(u_xlat32) * vec2(0.5, 0.5) + u_xlat0.xy;
					        u_xlat33 = (u_xlatb30) ? u_xlat0.x : u_xlat4.x;
					        u_xlat4.x = (u_xlatb30) ? u_xlat4.y : u_xlat0.y;
					        u_xlat5.x = (-u_xlat2.x) + u_xlat33;
					        u_xlat5.y = (-u_xlat13) + u_xlat4.x;
					        u_xlat6.x = u_xlat2.x + u_xlat33;
					        u_xlat6.y = u_xlat13 + u_xlat4.x;
					        u_xlat33 = u_xlat20 * -2.0 + 3.0;
					        u_xlat4 = textureLod(_MainTex, u_xlat5.xy, 0.0);
					        u_xlat20 = u_xlat20 * u_xlat20;
					        u_xlat7 = textureLod(_MainTex, u_xlat6.xy, 0.0);
					        u_xlat12.x = (u_xlatb23) ? u_xlat12.y : u_xlat12.x;
					        u_xlat22 = u_xlat3.x * 0.25;
					        u_xlat3.x = (-u_xlat12.x) * 0.5 + u_xlat1.y;
					        u_xlat20 = u_xlat20 * u_xlat33;
					        u_xlati3 = int((u_xlat3.x<0.0) ? 0xFFFFFFFFu : uint(0));
					        u_xlat4.y = (-u_xlat12.x) * 0.5 + u_xlat4.y;
					        u_xlat4.x = (-u_xlat12.x) * 0.5 + u_xlat7.y;
					        u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					        u_xlat25 = (-u_xlat2.x) + u_xlat5.x;
					        u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat25;
					        u_xlat35 = (-u_xlat13) + u_xlat5.y;
					        u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.y : u_xlat35;
					        u_xlati15.xz = ~(u_xlati23.xy);
					        u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					        u_xlat35 = u_xlat2.x + u_xlat6.x;
					        u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					        u_xlat35 = u_xlat13 + u_xlat6.y;
					        u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.y : u_xlat35;
					        if(u_xlati15.x != 0) {
					            if(u_xlati23.x == 0) {
					                u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					            } else {
					                u_xlat7.x = u_xlat4.y;
					            }
					            if(u_xlati23.y == 0) {
					                u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					            }
					            u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					            u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					            u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					            u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					            u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					            u_xlat15 = (-u_xlat2.x) + u_xlat5.x;
					            u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					            u_xlat15 = (-u_xlat13) + u_xlat5.z;
					            u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					            u_xlati15.xz = ~(u_xlati23.xy);
					            u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					            u_xlat35 = u_xlat2.x + u_xlat6.x;
					            u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					            u_xlat35 = u_xlat13 + u_xlat6.z;
					            u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					            if(u_xlati15.x != 0) {
					                if(u_xlati23.x == 0) {
					                    u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                } else {
					                    u_xlat7.x = u_xlat4.y;
					                }
					                if(u_xlati23.y == 0) {
					                    u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                }
					                u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                u_xlat15 = (-u_xlat2.x) + u_xlat5.x;
					                u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                u_xlat15 = (-u_xlat13) + u_xlat5.z;
					                u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                u_xlati15.xz = ~(u_xlati23.xy);
					                u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                u_xlat35 = u_xlat2.x + u_xlat6.x;
					                u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                u_xlat35 = u_xlat13 + u_xlat6.z;
					                u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                if(u_xlati15.x != 0) {
					                    if(u_xlati23.x == 0) {
					                        u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                    } else {
					                        u_xlat7.x = u_xlat4.y;
					                    }
					                    if(u_xlati23.y == 0) {
					                        u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                    }
					                    u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                    u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                    u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                    u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                    u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                    u_xlat15 = (-u_xlat2.x) + u_xlat5.x;
					                    u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                    u_xlat15 = (-u_xlat13) + u_xlat5.z;
					                    u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                    u_xlati15.xz = ~(u_xlati23.xy);
					                    u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                    u_xlat35 = u_xlat2.x + u_xlat6.x;
					                    u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                    u_xlat35 = u_xlat13 + u_xlat6.z;
					                    u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                    if(u_xlati15.x != 0) {
					                        if(u_xlati23.x == 0) {
					                            u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                        } else {
					                            u_xlat7.x = u_xlat4.y;
					                        }
					                        if(u_xlati23.y == 0) {
					                            u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                        }
					                        u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                        u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                        u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                        u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                        u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                        u_xlat15 = (-u_xlat2.x) * 1.5 + u_xlat5.x;
					                        u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                        u_xlat15 = (-u_xlat13) * 1.5 + u_xlat5.z;
					                        u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                        u_xlati15.xz = ~(u_xlati23.xy);
					                        u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                        u_xlat35 = u_xlat2.x * 1.5 + u_xlat6.x;
					                        u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                        u_xlat35 = u_xlat13 * 1.5 + u_xlat6.z;
					                        u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                        if(u_xlati15.x != 0) {
					                            if(u_xlati23.x == 0) {
					                                u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                            } else {
					                                u_xlat7.x = u_xlat4.y;
					                            }
					                            if(u_xlati23.y == 0) {
					                                u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                            }
					                            u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                            u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                            u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                            u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                            u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                            u_xlat15 = (-u_xlat2.x) * 2.0 + u_xlat5.x;
					                            u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                            u_xlat15 = (-u_xlat13) * 2.0 + u_xlat5.z;
					                            u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                            u_xlati15.xz = ~(u_xlati23.xy);
					                            u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                            u_xlat35 = u_xlat2.x * 2.0 + u_xlat6.x;
					                            u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                            u_xlat35 = u_xlat13 * 2.0 + u_xlat6.z;
					                            u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                            if(u_xlati15.x != 0) {
					                                if(u_xlati23.x == 0) {
					                                    u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                                } else {
					                                    u_xlat7.x = u_xlat4.y;
					                                }
					                                if(u_xlati23.y == 0) {
					                                    u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                                }
					                                u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                                u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                                u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                                u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                                u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                                u_xlat15 = (-u_xlat2.x) * 2.0 + u_xlat5.x;
					                                u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                                u_xlat15 = (-u_xlat13) * 2.0 + u_xlat5.z;
					                                u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                                u_xlati15.xz = ~(u_xlati23.xy);
					                                u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                                u_xlat35 = u_xlat2.x * 2.0 + u_xlat6.x;
					                                u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                                u_xlat35 = u_xlat13 * 2.0 + u_xlat6.z;
					                                u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                                if(u_xlati15.x != 0) {
					                                    if(u_xlati23.x == 0) {
					                                        u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                                    } else {
					                                        u_xlat7.x = u_xlat4.y;
					                                    }
					                                    if(u_xlati23.y == 0) {
					                                        u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                                    }
					                                    u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                                    u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                                    u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                                    u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                                    u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                                    u_xlat15 = (-u_xlat2.x) * 2.0 + u_xlat5.x;
					                                    u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                                    u_xlat15 = (-u_xlat13) * 2.0 + u_xlat5.z;
					                                    u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                                    u_xlati15.xz = ~(u_xlati23.xy);
					                                    u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                                    u_xlat35 = u_xlat2.x * 2.0 + u_xlat6.x;
					                                    u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                                    u_xlat35 = u_xlat13 * 2.0 + u_xlat6.z;
					                                    u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                                    if(u_xlati15.x != 0) {
					                                        if(u_xlati23.x == 0) {
					                                            u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                                        } else {
					                                            u_xlat7.x = u_xlat4.y;
					                                        }
					                                        if(u_xlati23.y == 0) {
					                                            u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                                        }
					                                        u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                                        u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                                        u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                                        u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                                        u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                                        u_xlat15 = (-u_xlat2.x) * 2.0 + u_xlat5.x;
					                                        u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                                        u_xlat15 = (-u_xlat13) * 2.0 + u_xlat5.z;
					                                        u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                                        u_xlati15.xz = ~(u_xlati23.xy);
					                                        u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                                        u_xlat35 = u_xlat2.x * 2.0 + u_xlat6.x;
					                                        u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                                        u_xlat35 = u_xlat13 * 2.0 + u_xlat6.z;
					                                        u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                                        if(u_xlati15.x != 0) {
					                                            if(u_xlati23.x == 0) {
					                                                u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                                            } else {
					                                                u_xlat7.x = u_xlat4.y;
					                                            }
					                                            if(u_xlati23.y == 0) {
					                                                u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                                            }
					                                            u_xlat15 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                                            u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat15;
					                                            u_xlat23 = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                                            u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat23;
					                                            u_xlati23.xy = ivec2(uvec2(greaterThanEqual(abs(u_xlat4.yxyx), vec4(u_xlat22)).xy) * 0xFFFFFFFFu);
					                                            u_xlat15 = (-u_xlat2.x) * 4.0 + u_xlat5.x;
					                                            u_xlat5.x = (u_xlati23.x != 0) ? u_xlat5.x : u_xlat15;
					                                            u_xlat15 = (-u_xlat13) * 4.0 + u_xlat5.z;
					                                            u_xlat5.z = (u_xlati23.x != 0) ? u_xlat5.z : u_xlat15;
					                                            u_xlati15.xz = ~(u_xlati23.xy);
					                                            u_xlati15.x = int(uint(u_xlati15.z) | uint(u_xlati15.x));
					                                            u_xlat35 = u_xlat2.x * 4.0 + u_xlat6.x;
					                                            u_xlat6.x = (u_xlati23.y != 0) ? u_xlat6.x : u_xlat35;
					                                            u_xlat35 = u_xlat13 * 4.0 + u_xlat6.z;
					                                            u_xlat6.z = (u_xlati23.y != 0) ? u_xlat6.z : u_xlat35;
					                                            if(u_xlati15.x != 0) {
					                                                if(u_xlati23.x == 0) {
					                                                    u_xlat7 = textureLod(_MainTex, u_xlat5.xz, 0.0).yxzw;
					                                                } else {
					                                                    u_xlat7.x = u_xlat4.y;
					                                                }
					                                                if(u_xlati23.y == 0) {
					                                                    u_xlat4 = textureLod(_MainTex, u_xlat6.xz, 0.0).yxzw;
					                                                }
					                                                u_xlat24 = (-u_xlat12.x) * 0.5 + u_xlat7.x;
					                                                u_xlat4.y = (u_xlati23.x != 0) ? u_xlat7.x : u_xlat24;
					                                                u_xlat12.x = (-u_xlat12.x) * 0.5 + u_xlat4.x;
					                                                u_xlat4.x = (u_xlati23.y != 0) ? u_xlat4.x : u_xlat12.x;
					                                                u_xlatb12.xy = greaterThanEqual(abs(u_xlat4.yxyy), vec4(u_xlat22)).xy;
					                                                u_xlat23 = (-u_xlat2.x) * 8.0 + u_xlat5.x;
					                                                u_xlat5.x = (u_xlatb12.x) ? u_xlat5.x : u_xlat23;
					                                                u_xlat23 = (-u_xlat13) * 8.0 + u_xlat5.z;
					                                                u_xlat5.z = (u_xlatb12.x) ? u_xlat5.z : u_xlat23;
					                                                u_xlat2.x = u_xlat2.x * 8.0 + u_xlat6.x;
					                                                u_xlat6.x = (u_xlatb12.y) ? u_xlat6.x : u_xlat2.x;
					                                                u_xlat2.x = u_xlat13 * 8.0 + u_xlat6.z;
					                                                u_xlat6.z = (u_xlatb12.y) ? u_xlat6.z : u_xlat2.x;
					                                            }
					                                        }
					                                    }
					                                }
					                            }
					                        }
					                    }
					                }
					            }
					        }
					        u_xlat2.xz = u_xlat0.xy + (-u_xlat5.xz);
					        u_xlat2.x = (u_xlatb30) ? u_xlat2.x : u_xlat2.z;
					        u_xlat12.xy = (-u_xlat0.xy) + u_xlat6.xz;
					        u_xlat12.x = (u_xlatb30) ? u_xlat12.x : u_xlat12.y;
					        u_xlati13.xy = ivec2(uvec2(lessThan(u_xlat4.yxyy, vec4(0.0, 0.0, 0.0, 0.0)).xy) * 0xFFFFFFFFu);
					        u_xlat22 = u_xlat2.x + u_xlat12.x;
					        u_xlatb3.xy = notEqual(ivec4(u_xlati3), u_xlati13.xyxx).xy;
					        u_xlat22 = float(1.0) / u_xlat22;
					        u_xlatb23 = u_xlat2.x<u_xlat12.x;
					        u_xlat2.x = min(u_xlat12.x, u_xlat2.x);
					        u_xlatb12.x = (u_xlatb23) ? u_xlatb3.x : u_xlatb3.y;
					        u_xlat20 = u_xlat20 * u_xlat20;
					        u_xlat2.x = u_xlat2.x * (-u_xlat22) + 0.5;
					        u_xlat20 = u_xlat20 * _QualitySettings.x;
					        u_xlat2.x = u_xlatb12.x ? u_xlat2.x : float(0.0);
					        u_xlat20 = max(u_xlat20, u_xlat2.x);
					        u_xlat2.xy = vec2(u_xlat20) * vec2(u_xlat32) + u_xlat0.xy;
					        u_xlat3.x = (u_xlatb30) ? u_xlat0.x : u_xlat2.x;
					        u_xlat3.y = (u_xlatb30) ? u_xlat2.y : u_xlat0.y;
					        u_xlat1 = textureLod(_MainTex, u_xlat3.xy, 0.0);
					    }
					    u_xlat0.xy = vs_TEXCOORD0.xy * _Grain_Params2.xy + _Grain_Params2.zw;
					    u_xlat0 = texture(_GrainTex, u_xlat0.xy);
					    u_xlat30 = dot(u_xlat1.xyz, vec3(0.212599993, 0.715200007, 0.0722000003));
					    u_xlat30 = sqrt(u_xlat30);
					    u_xlat30 = _Grain_Params1.x * (-u_xlat30) + 1.0;
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * _Grain_Params1.yyy;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(u_xlat30) + u_xlat1.xyz;
					    u_xlat1.xy = vs_TEXCOORD0.xy * _DitheringCoords.xy + _DitheringCoords.zw;
					    u_xlat1 = texture(_DitheringTex, u_xlat1.xy);
					    u_xlat30 = u_xlat1.w * 2.0 + -1.0;
					    u_xlati1 = int((0.0<u_xlat30) ? 0xFFFFFFFFu : uint(0));
					    u_xlati11 = int((u_xlat30<0.0) ? 0xFFFFFFFFu : uint(0));
					    u_xlati1 = (-u_xlati1) + u_xlati11;
					    u_xlat1.x = float(u_xlati1);
					    u_xlat30 = -abs(u_xlat30) + 1.0;
					    u_xlat30 = sqrt(u_xlat30);
					    u_xlat30 = (-u_xlat30) + 1.0;
					    u_xlat30 = u_xlat30 * u_xlat1.x;
					    SV_Target0.xyz = vec3(u_xlat30) * vec3(0.00392156886, 0.00392156886, 0.00392156886) + u_xlat0.xyz;
					    SV_Target0.w = 1.0;
					    return;
					}"
				}
			}
		}
	}
}