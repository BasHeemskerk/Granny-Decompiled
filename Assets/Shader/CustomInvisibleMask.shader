Shader "Custom/InvisibleMask" {
	Properties {
	}
	SubShader {
		Tags { "QUEUE" = "Geometry+1" }
		Pass {
			Tags { "QUEUE" = "Geometry+1" }
			Blend Zero One, Zero One
			Fog {
				Mode Off
			}
			GpuProgramID 11839
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
					layout(std140) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_0_1[6];
					};
					layout(std140) uniform UnityPerFrame {
						vec4 unused_1_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_1_2[2];
					};
					in  vec3 in_POSITION0;
					in  vec4 in_COLOR0;
					out vec4 vs_COLOR0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    vs_COLOR0 = in_COLOR0;
					    vs_COLOR0 = clamp(vs_COLOR0, 0.0, 1.0);
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "FOG_LINEAR" }
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
					layout(std140) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_0_1[6];
					};
					layout(std140) uniform UnityPerFrame {
						vec4 unused_1_0[9];
						mat4x4 unity_MatrixV;
						vec4 unused_1_2[4];
						mat4x4 unity_MatrixVP;
						vec4 unused_1_4[2];
					};
					layout(std140) uniform UnityFog {
						vec4 unused_2_0;
						vec4 unity_FogParams;
					};
					in  vec3 in_POSITION0;
					in  vec4 in_COLOR0;
					out vec4 vs_COLOR0;
					out float vs_TEXCOORD0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    vs_COLOR0 = in_COLOR0;
					    vs_COLOR0 = clamp(vs_COLOR0, 0.0, 1.0);
					    u_xlat0.xyz = unity_ObjectToWorld[1].yyy * unity_MatrixV[1].xyz;
					    u_xlat0.xyz = unity_MatrixV[0].xyz * unity_ObjectToWorld[1].xxx + u_xlat0.xyz;
					    u_xlat0.xyz = unity_MatrixV[2].xyz * unity_ObjectToWorld[1].zzz + u_xlat0.xyz;
					    u_xlat0.xyz = unity_MatrixV[3].xyz * unity_ObjectToWorld[1].www + u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * in_POSITION0.yyy;
					    u_xlat1.xyz = unity_ObjectToWorld[0].yyy * unity_MatrixV[1].xyz;
					    u_xlat1.xyz = unity_MatrixV[0].xyz * unity_ObjectToWorld[0].xxx + u_xlat1.xyz;
					    u_xlat1.xyz = unity_MatrixV[2].xyz * unity_ObjectToWorld[0].zzz + u_xlat1.xyz;
					    u_xlat1.xyz = unity_MatrixV[3].xyz * unity_ObjectToWorld[0].www + u_xlat1.xyz;
					    u_xlat0.xyz = u_xlat1.xyz * in_POSITION0.xxx + u_xlat0.xyz;
					    u_xlat1.xyz = unity_ObjectToWorld[2].yyy * unity_MatrixV[1].xyz;
					    u_xlat1.xyz = unity_MatrixV[0].xyz * unity_ObjectToWorld[2].xxx + u_xlat1.xyz;
					    u_xlat1.xyz = unity_MatrixV[2].xyz * unity_ObjectToWorld[2].zzz + u_xlat1.xyz;
					    u_xlat1.xyz = unity_MatrixV[3].xyz * unity_ObjectToWorld[2].www + u_xlat1.xyz;
					    u_xlat0.xyz = u_xlat1.xyz * in_POSITION0.zzz + u_xlat0.xyz;
					    u_xlat1.xyz = unity_ObjectToWorld[3].yyy * unity_MatrixV[1].xyz;
					    u_xlat1.xyz = unity_MatrixV[0].xyz * unity_ObjectToWorld[3].xxx + u_xlat1.xyz;
					    u_xlat1.xyz = unity_MatrixV[2].xyz * unity_ObjectToWorld[3].zzz + u_xlat1.xyz;
					    u_xlat1.xyz = unity_MatrixV[3].xyz * unity_ObjectToWorld[3].www + u_xlat1.xyz;
					    u_xlat0.xyz = u_xlat0.xyz + u_xlat1.xyz;
					    u_xlat0.x = dot(u_xlat0.xyz, u_xlat0.xyz);
					    u_xlat0.x = sqrt(u_xlat0.x);
					    vs_TEXCOORD0 = u_xlat0.x * unity_FogParams.z + unity_FogParams.w;
					    vs_TEXCOORD0 = clamp(vs_TEXCOORD0, 0.0, 1.0);
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
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
					
					in  vec4 vs_COLOR0;
					layout(location = 0) out vec4 SV_Target0;
					void main()
					{
					    SV_Target0 = vs_COLOR0;
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "FOG_LINEAR" }
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
					layout(std140) uniform UnityFog {
						vec4 unity_FogColor;
						vec4 unused_0_1;
					};
					in  vec4 vs_COLOR0;
					in  float vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					vec3 u_xlat0;
					void main()
					{
					    u_xlat0.xyz = vs_COLOR0.xyz + (-unity_FogColor.xyz);
					    SV_Target0.xyz = vec3(vs_TEXCOORD0) * u_xlat0.xyz + unity_FogColor.xyz;
					    SV_Target0.w = vs_COLOR0.w;
					    return;
					}"
				}
			}
		}
	}
}