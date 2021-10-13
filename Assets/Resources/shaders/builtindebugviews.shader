Shader "Hidden/Post FX/Builtin Debug Views" {
	Properties {
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 24293
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
						vec4 unused_0_0[4];
						vec4 _CameraDepthTexture_ST;
						vec4 unused_0_2[2];
						float _DepthScale;
						vec4 unused_0_4;
					};
					layout(std140) uniform UnityPerCamera {
						vec4 unused_1_0[7];
						vec4 _ZBufferParams;
						vec4 unused_1_2;
					};
					uniform  sampler2D _CameraDepthTexture;
					in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD0.xy * _CameraDepthTexture_ST.xy + _CameraDepthTexture_ST.zw;
					    u_xlat0 = texture(_CameraDepthTexture, u_xlat0.xy);
					    u_xlat0.x = _ZBufferParams.x * u_xlat0.x + _ZBufferParams.y;
					    u_xlat0.x = float(1.0) / u_xlat0.x;
					    SV_Target0.xyz = u_xlat0.xxx * vec3(_DepthScale);
					    SV_Target0.w = 1.0;
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 116861
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
					Keywords { "SOURCE_GBUFFER" }
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
						vec4 unused_0_2[6];
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
						vec4 unused_0_0[5];
						vec4 _CameraDepthNormalsTexture_ST;
						vec4 unused_0_2[3];
					};
					uniform  sampler2D _CameraDepthNormalsTexture;
					in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec3 u_xlat1;
					float u_xlat4;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD0.xy * _CameraDepthNormalsTexture_ST.xy + _CameraDepthNormalsTexture_ST.zw;
					    u_xlat0 = texture(_CameraDepthNormalsTexture, u_xlat0.xy);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.55539989, 3.55539989, 0.0) + vec3(-1.77769995, -1.77769995, 1.0);
					    u_xlat4 = dot(u_xlat0.xyz, u_xlat0.xyz);
					    u_xlat4 = 2.0 / u_xlat4;
					    u_xlat1.xy = u_xlat0.xy * vec2(u_xlat4);
					    u_xlat1.z = u_xlat4 + -1.0;
					    u_xlat0.xyz = u_xlat1.xyz * vec3(1.0, 1.0, -1.0);
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat0.xyz = log2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.416666657, 0.416666657, 0.416666657);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(1.05499995, 1.05499995, 1.05499995) + vec3(-0.0549999997, -0.0549999997, -0.0549999997);
					    SV_Target0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    SV_Target0.w = 1.0;
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "SOURCE_GBUFFER" }
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
						vec4 unused_0_0[5];
						vec4 _CameraDepthNormalsTexture_ST;
						vec4 unused_0_2[4];
					};
					layout(std140) uniform UnityPerCameraRare {
						vec4 unused_1_0[14];
						mat4x4 unity_WorldToCamera;
						vec4 unused_1_2[4];
					};
					uniform  sampler2D _CameraGBufferTexture2;
					in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec3 u_xlat1;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD0.xy * _CameraDepthNormalsTexture_ST.xy + _CameraDepthNormalsTexture_ST.zw;
					    u_xlat0 = texture(_CameraGBufferTexture2, u_xlat0.xy);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat0.yyy * unity_WorldToCamera[1].xyz;
					    u_xlat0.xyw = unity_WorldToCamera[0].xyz * u_xlat0.xxx + u_xlat1.xyz;
					    u_xlat0.xyz = unity_WorldToCamera[2].xyz * u_xlat0.zzz + u_xlat0.xyw;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat0.xyz = log2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.416666657, 0.416666657, 0.416666657);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(1.05499995, 1.05499995, 1.05499995) + vec3(-0.0549999997, -0.0549999997, -0.0549999997);
					    SV_Target0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    SV_Target0.w = 1.0;
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 159781
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
						vec4 unused_0_0[7];
						float _Opacity;
						vec4 unused_0_2;
					};
					uniform  sampler2D _MainTex;
					in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					void main()
					{
					    u_xlat0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    SV_Target0.xyz = u_xlat0.xyz * vec3(vec3(_Opacity, _Opacity, _Opacity));
					    SV_Target0.w = u_xlat0.w;
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 232283
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
					Keywords { "UNITY_COLORSPACE_GAMMA" }
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
						vec4 unused_0_0[7];
						float _Opacity;
						float _Amplitude;
						vec4 unused_0_3;
					};
					uniform  sampler2D _MainTex;
					uniform  sampler2D _CameraMotionVectorsTexture;
					in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					bool u_xlatb1;
					float u_xlat2;
					float u_xlat3;
					float u_xlat4;
					bool u_xlatb4;
					float u_xlat5;
					bool u_xlatb7;
					void main()
					{
					    u_xlat0 = texture(_CameraMotionVectorsTexture, vs_TEXCOORD0.xy);
					    u_xlat0.yz = u_xlat0.xy * vec2(vec2(_Amplitude, _Amplitude));
					    u_xlat0.xw = (-u_xlat0.zz);
					    u_xlat1.x = max(abs(u_xlat0.x), abs(u_xlat0.y));
					    u_xlat1.x = float(1.0) / u_xlat1.x;
					    u_xlat3 = min(abs(u_xlat0.x), abs(u_xlat0.y));
					    u_xlat1.x = u_xlat1.x * u_xlat3;
					    u_xlat3 = u_xlat1.x * u_xlat1.x;
					    u_xlat5 = u_xlat3 * 0.0208350997 + -0.0851330012;
					    u_xlat5 = u_xlat3 * u_xlat5 + 0.180141002;
					    u_xlat5 = u_xlat3 * u_xlat5 + -0.330299497;
					    u_xlat3 = u_xlat3 * u_xlat5 + 0.999866009;
					    u_xlat5 = u_xlat3 * u_xlat1.x;
					    u_xlat5 = u_xlat5 * -2.0 + 1.57079637;
					    u_xlatb7 = abs(u_xlat0.x)<abs(u_xlat0.y);
					    u_xlat5 = u_xlatb7 ? u_xlat5 : float(0.0);
					    u_xlat1.x = u_xlat1.x * u_xlat3 + u_xlat5;
					    u_xlatb4 = u_xlat0.x<u_xlat0.z;
					    u_xlat4 = u_xlatb4 ? -3.14159274 : float(0.0);
					    u_xlat4 = u_xlat4 + u_xlat1.x;
					    u_xlat1.x = min(u_xlat0.x, u_xlat0.y);
					    u_xlatb1 = u_xlat1.x<(-u_xlat1.x);
					    u_xlat0.x = max(u_xlat0.x, u_xlat0.y);
					    u_xlat2 = dot(u_xlat0.yw, u_xlat0.yw);
					    u_xlat2 = sqrt(u_xlat2);
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					    u_xlat2 = u_xlat2 * _Opacity;
					    u_xlatb0 = u_xlat0.x>=(-u_xlat0.x);
					    u_xlatb0 = u_xlatb0 && u_xlatb1;
					    u_xlat0.x = (u_xlatb0) ? (-u_xlat4) : u_xlat4;
					    u_xlat0.x = u_xlat0.x * 0.318309873 + 1.0;
					    u_xlat0.xzw = u_xlat0.xxx * vec3(3.0, 3.0, 3.0) + vec3(-3.0, -2.0, -4.0);
					    u_xlat0.xzw = abs(u_xlat0.xzw) * vec3(1.0, -1.0, -1.0) + vec3(-1.0, 2.0, 2.0);
					    u_xlat0.xzw = clamp(u_xlat0.xzw, 0.0, 1.0);
					    u_xlat1 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat0.xzw = u_xlat0.xzw + (-u_xlat1.xyz);
					    SV_Target0.xyz = vec3(u_xlat2) * u_xlat0.xzw + u_xlat1.xyz;
					    SV_Target0.w = u_xlat1.w;
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "UNITY_COLORSPACE_GAMMA" }
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
						vec4 unused_0_0[7];
						float _Opacity;
						float _Amplitude;
						vec4 unused_0_3;
					};
					uniform  sampler2D _MainTex;
					uniform  sampler2D _CameraMotionVectorsTexture;
					in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					bool u_xlatb1;
					float u_xlat2;
					float u_xlat3;
					float u_xlat4;
					bool u_xlatb4;
					float u_xlat5;
					bool u_xlatb7;
					void main()
					{
					    u_xlat0 = texture(_CameraMotionVectorsTexture, vs_TEXCOORD0.xy);
					    u_xlat0.yz = u_xlat0.xy * vec2(vec2(_Amplitude, _Amplitude));
					    u_xlat0.xw = (-u_xlat0.zz);
					    u_xlat1.x = max(abs(u_xlat0.x), abs(u_xlat0.y));
					    u_xlat1.x = float(1.0) / u_xlat1.x;
					    u_xlat3 = min(abs(u_xlat0.x), abs(u_xlat0.y));
					    u_xlat1.x = u_xlat1.x * u_xlat3;
					    u_xlat3 = u_xlat1.x * u_xlat1.x;
					    u_xlat5 = u_xlat3 * 0.0208350997 + -0.0851330012;
					    u_xlat5 = u_xlat3 * u_xlat5 + 0.180141002;
					    u_xlat5 = u_xlat3 * u_xlat5 + -0.330299497;
					    u_xlat3 = u_xlat3 * u_xlat5 + 0.999866009;
					    u_xlat5 = u_xlat3 * u_xlat1.x;
					    u_xlat5 = u_xlat5 * -2.0 + 1.57079637;
					    u_xlatb7 = abs(u_xlat0.x)<abs(u_xlat0.y);
					    u_xlat5 = u_xlatb7 ? u_xlat5 : float(0.0);
					    u_xlat1.x = u_xlat1.x * u_xlat3 + u_xlat5;
					    u_xlatb4 = u_xlat0.x<u_xlat0.z;
					    u_xlat4 = u_xlatb4 ? -3.14159274 : float(0.0);
					    u_xlat4 = u_xlat4 + u_xlat1.x;
					    u_xlat1.x = min(u_xlat0.x, u_xlat0.y);
					    u_xlatb1 = u_xlat1.x<(-u_xlat1.x);
					    u_xlat0.x = max(u_xlat0.x, u_xlat0.y);
					    u_xlat2 = dot(u_xlat0.yw, u_xlat0.yw);
					    u_xlat2 = sqrt(u_xlat2);
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					    u_xlat2 = u_xlat2 * _Opacity;
					    u_xlatb0 = u_xlat0.x>=(-u_xlat0.x);
					    u_xlatb0 = u_xlatb0 && u_xlatb1;
					    u_xlat0.x = (u_xlatb0) ? (-u_xlat4) : u_xlat4;
					    u_xlat0.x = u_xlat0.x * 0.318309873 + 1.0;
					    u_xlat0.xzw = u_xlat0.xxx * vec3(3.0, 3.0, 3.0) + vec3(-3.0, -2.0, -4.0);
					    u_xlat0.xzw = abs(u_xlat0.xzw) * vec3(1.0, -1.0, -1.0) + vec3(-1.0, 2.0, 2.0);
					    u_xlat0.xzw = clamp(u_xlat0.xzw, 0.0, 1.0);
					    u_xlat1 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat0.xzw = u_xlat0.xzw + (-u_xlat1.xyz);
					    SV_Target0.xyz = vec3(u_xlat2) * u_xlat0.xzw + u_xlat1.xyz;
					    SV_Target0.w = u_xlat1.w;
					    return;
					}"
				}
			}
		}
		Pass {
			Blend SrcAlpha OneMinusSrcAlpha, SrcAlpha OneMinusSrcAlpha
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 290292
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
						vec4 unused_0_0[7];
						float _Opacity;
						float _Amplitude;
						vec4 _Scale;
					};
					layout(std140) uniform UnityPerCamera {
						vec4 unused_1_0[6];
						vec4 _ScreenParams;
						vec4 unused_1_2[2];
					};
					uniform  sampler2D _CameraMotionVectorsTexture;
					in  vec4 in_POSITION0;
					in  vec4 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					out vec4 vs_COLOR0;
					vec3 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					vec3 u_xlat2;
					vec2 u_xlat3;
					vec2 u_xlat4;
					float u_xlat5;
					bool u_xlatb5;
					vec2 u_xlat10;
					bool u_xlatb10;
					float u_xlat15;
					void main()
					{
					    u_xlat0.y = -abs(in_POSITION0.x);
					    u_xlat0.x = in_POSITION0.x;
					    u_xlat10.xy = in_TEXCOORD0.xy * vec2(1.0, -1.0) + vec2(0.0, 1.0);
					    u_xlat1 = textureLod(_CameraMotionVectorsTexture, u_xlat10.xy, 0.0);
					    u_xlat1.xy = u_xlat1.xy * vec2(vec2(_Amplitude, _Amplitude));
					    u_xlat1.zw = (-u_xlat1.yy);
					    u_xlat10.x = dot(u_xlat1.xz, u_xlat1.xz);
					    u_xlat15 = sqrt(u_xlat10.x);
					    u_xlat15 = clamp(u_xlat15, 0.0, 1.0);
					    u_xlat10.x = inversesqrt(u_xlat10.x);
					    u_xlat2.xy = u_xlat10.xx * u_xlat1.xw;
					    u_xlat3.x = dot(u_xlat1.xw, in_POSITION0.yz);
					    u_xlat0.xy = vec2(u_xlat15) * u_xlat0.xy;
					    vs_COLOR0.w = u_xlat15 * _Opacity;
					    vs_COLOR0.w = clamp(vs_COLOR0.w, 0.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.300000012, 0.300000012);
					    u_xlat2.z = (-u_xlat2.x);
					    u_xlat4.y = dot(u_xlat2.zy, u_xlat0.xy);
					    u_xlat4.x = dot(u_xlat2.yx, u_xlat0.xy);
					    u_xlat0.xy = u_xlat4.xy * _Scale.xy;
					    u_xlat3.y = dot((-u_xlat1.yx), in_POSITION0.yz);
					    u_xlat0.xy = u_xlat3.xy * _Scale.xy + u_xlat0.xy;
					    u_xlat0.xy = in_TEXCOORD0.xy * vec2(2.0, 2.0) + u_xlat0.xy;
					    u_xlat0.xy = u_xlat0.xy * _ScreenParams.xy;
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    u_xlat0.xy = roundEven(u_xlat0.xy);
					    u_xlat10.xy = u_xlat0.xy + vec2(0.5, 0.5);
					    vs_TEXCOORD0.xy = u_xlat0.xy;
					    u_xlat0.xy = _ScreenParams.zw + vec2(-1.0, -1.0);
					    u_xlat0.xy = u_xlat0.xy * u_xlat10.xy;
					    gl_Position.xy = u_xlat0.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.x = abs(u_xlat1.y);
					    u_xlat5 = max(u_xlat0.x, abs(u_xlat1.x));
					    u_xlat5 = float(1.0) / u_xlat5;
					    u_xlat10.x = min(u_xlat0.x, abs(u_xlat1.x));
					    u_xlatb0 = u_xlat0.x<abs(u_xlat1.x);
					    u_xlat5 = u_xlat5 * u_xlat10.x;
					    u_xlat10.x = u_xlat5 * u_xlat5;
					    u_xlat15 = u_xlat10.x * 0.0208350997 + -0.0851330012;
					    u_xlat15 = u_xlat10.x * u_xlat15 + 0.180141002;
					    u_xlat15 = u_xlat10.x * u_xlat15 + -0.330299497;
					    u_xlat10.x = u_xlat10.x * u_xlat15 + 0.999866009;
					    u_xlat15 = u_xlat10.x * u_xlat5;
					    u_xlat15 = u_xlat15 * -2.0 + 1.57079637;
					    u_xlat0.x = u_xlatb0 ? u_xlat15 : float(0.0);
					    u_xlat0.x = u_xlat5 * u_xlat10.x + u_xlat0.x;
					    u_xlatb5 = (-u_xlat1.y)<u_xlat1.y;
					    u_xlat5 = u_xlatb5 ? -3.14159274 : float(0.0);
					    u_xlat0.x = u_xlat5 + u_xlat0.x;
					    u_xlat5 = min((-u_xlat1.y), u_xlat1.x);
					    u_xlat10.x = max((-u_xlat1.y), u_xlat1.x);
					    u_xlatb10 = u_xlat10.x>=(-u_xlat10.x);
					    u_xlatb5 = u_xlat5<(-u_xlat5);
					    u_xlatb5 = u_xlatb10 && u_xlatb5;
					    u_xlat0.x = (u_xlatb5) ? (-u_xlat0.x) : u_xlat0.x;
					    u_xlat0.x = u_xlat0.x * 0.318309873 + 1.0;
					    u_xlat0.xyz = u_xlat0.xxx * vec3(3.0, 3.0, 3.0) + vec3(-3.0, -2.0, -4.0);
					    u_xlat0.xyz = abs(u_xlat0.xyz) * vec3(1.0, -1.0, -1.0) + vec3(-1.0, 2.0, 2.0);
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					    u_xlat1.xyz = (-u_xlat0.xyz) + vec3(1.0, 1.0, 1.0);
					    u_xlat0.xyz = u_xlat1.xyz * vec3(0.5, 0.5, 0.5) + u_xlat0.xyz;
					    u_xlat1.xyz = u_xlat0.xyz * vec3(0.305306017, 0.305306017, 0.305306017) + vec3(0.682171106, 0.682171106, 0.682171106);
					    u_xlat1.xyz = u_xlat0.xyz * u_xlat1.xyz + vec3(0.0125228781, 0.0125228781, 0.0125228781);
					    vs_COLOR0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    vs_COLOR0.xyz = clamp(vs_COLOR0.xyz, 0.0, 1.0);
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
					
					in  vec2 vs_TEXCOORD0;
					in  vec4 vs_COLOR0;
					layout(location = 0) out vec4 SV_Target0;
					vec2 u_xlat0;
					float u_xlat1;
					void main()
					{
					    u_xlat0.xy = fract(vs_TEXCOORD0.xy);
					    u_xlat0.xy = u_xlat0.xy + vec2(-0.5, -0.5);
					    u_xlat0.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat0.x = sqrt(u_xlat0.x);
					    u_xlat1 = u_xlat0.x * 0.431833118 + 0.682171106;
					    u_xlat0.x = u_xlat0.x * 1.41442716;
					    u_xlat1 = u_xlat0.x * u_xlat1 + 0.0125228781;
					    u_xlat0.x = u_xlat1 * u_xlat0.x;
					    SV_Target0.w = u_xlat0.x * vs_COLOR0.w;
					    SV_Target0.xyz = vs_COLOR0.xyz;
					    return;
					}"
				}
			}
		}
	}
}