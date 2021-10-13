Shader "Hidden/Post FX/Screen Space Reflection" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "white" {}
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 32157
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
						vec4 unused_0_0[4];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[30];
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
					in  vec2 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					 vec4 phase0_Output0_1;
					out vec2 vs_TEXCOORD1;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					float u_xlat2;
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
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat2 = (-in_TEXCOORD0.y) + 1.0;
					    phase0_Output0_1.w = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    phase0_Output0_1.xyz = in_TEXCOORD0.xyx;
					vs_TEXCOORD0 = phase0_Output0_1.xy;
					vs_TEXCOORD1 = phase0_Output0_1.zw;
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
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2;
						vec4 _ProjInfo;
						mat4x4 _WorldToCameraMatrix;
						mat4x4 _CameraToWorldMatrix;
						mat4x4 _ProjectToPixelMatrix;
						vec2 _ScreenSize;
						vec4 unused_0_8[2];
						float _RayStepSize;
						float _MaxRayTraceDistance;
						float _LayerThickness;
						float _FresnelFade;
						float _FresnelFadePower;
						int _TreatBackfaceHitAsMiss;
						int _AllowBackwardsRays;
						float _ScreenEdgeFading;
						int _MaxSteps;
						vec4 unused_0_18;
						float _FadeDistance;
						int _TraceBehindObjects;
						vec4 unused_0_21[8];
					};
					layout(std140) uniform UnityPerCamera {
						vec4 unused_1_0[7];
						vec4 _ZBufferParams;
						vec4 unused_1_2;
					};
					uniform  sampler2D _CameraDepthTexture;
					uniform  sampler2D _CameraGBufferTexture1;
					uniform  sampler2D _CameraGBufferTexture2;
					in  vec2 vs_TEXCOORD1;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec3 u_xlat3;
					vec3 u_xlat4;
					vec4 u_xlat5;
					vec3 u_xlat6;
					vec4 u_xlat7;
					vec3 u_xlat8;
					float u_xlat9;
					bvec2 u_xlatb9;
					vec2 u_xlat10;
					vec2 u_xlat11;
					vec4 u_xlat12;
					vec3 u_xlat13;
					bool u_xlatb13;
					float u_xlat19;
					bool u_xlatb19;
					float u_xlat22;
					float u_xlat26;
					bool u_xlatb26;
					vec2 u_xlat30;
					vec2 u_xlat32;
					bool u_xlatb32;
					vec2 u_xlat33;
					int u_xlati33;
					vec2 u_xlat35;
					int u_xlati35;
					bvec2 u_xlatb35;
					vec2 u_xlat36;
					float u_xlat39;
					bool u_xlatb39;
					float u_xlat40;
					bool u_xlatb40;
					float u_xlat41;
					bool u_xlatb41;
					float u_xlat42;
					bool u_xlatb42;
					float u_xlat44;
					int u_xlati44;
					int u_xlati45;
					int u_xlati46;
					int u_xlati47;
					float u_xlat48;
					int u_xlati48;
					bool u_xlatb48;
					void main()
					{
					    u_xlat0 = texture(_CameraDepthTexture, vs_TEXCOORD1.xy);
					    u_xlat0.x = _ZBufferParams.z * u_xlat0.x + _ZBufferParams.w;
					    u_xlat0.x = float(1.0) / u_xlat0.x;
					    u_xlat1.z = (-u_xlat0.x);
					    u_xlat2 = texture(_CameraGBufferTexture1, vs_TEXCOORD1.xy);
					    u_xlatb13 = u_xlat1.z<-100.0;
					    u_xlatb26 = u_xlat2.w==0.0;
					    u_xlatb13 = u_xlatb26 || u_xlatb13;
					    if(!u_xlatb13){
					        u_xlat13.xy = vs_TEXCOORD1.xy * _MainTex_TexelSize.zw;
					        u_xlat13.xy = u_xlat13.xy * _ProjInfo.xy + _ProjInfo.zw;
					        u_xlat1.xy = u_xlat1.zz * u_xlat13.xy;
					        u_xlat2 = texture(_CameraGBufferTexture2, vs_TEXCOORD1.xy);
					        u_xlat13.xyz = u_xlat2.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					        u_xlat2.xyz = u_xlat13.yyy * _WorldToCameraMatrix[1].xyz;
					        u_xlat2.xyz = _WorldToCameraMatrix[0].xyz * u_xlat13.xxx + u_xlat2.xyz;
					        u_xlat13.xyz = _WorldToCameraMatrix[2].xyz * u_xlat13.zzz + u_xlat2.xyz;
					        u_xlat40 = dot(u_xlat1.xyz, u_xlat1.xyz);
					        u_xlat40 = inversesqrt(u_xlat40);
					        u_xlat2.xyz = vec3(u_xlat40) * u_xlat1.xyz;
					        u_xlat40 = dot(u_xlat13.xyz, (-u_xlat2.xyz));
					        u_xlat40 = u_xlat40 + u_xlat40;
					        u_xlat3.xyz = u_xlat13.xyz * vec3(u_xlat40) + u_xlat2.xyz;
					        u_xlat40 = dot(u_xlat3.xyz, u_xlat3.xyz);
					        u_xlat40 = inversesqrt(u_xlat40);
					        u_xlat3.xyz = vec3(u_xlat40) * u_xlat3.xyz;
					        u_xlatb40 = _AllowBackwardsRays==0;
					        u_xlatb41 = 0.0<u_xlat3.z;
					        u_xlatb40 = u_xlatb40 && u_xlatb41;
					        if(!u_xlatb40){
					            u_xlat0.x = u_xlat0.x * 0.00999999978;
					            u_xlat0.x = max(u_xlat0.x, 0.00100000005);
					            u_xlat0.xyz = u_xlat13.xyz * u_xlat0.xxx + u_xlat1.xyz;
					            u_xlatb39 = floatBitsToInt(unused_0_18.z)==1;
					            u_xlat4.xy = vec2(1.0, 1.0) / _ScreenSize.xy;
					            u_xlat40 = u_xlat3.z * _MaxRayTraceDistance + u_xlat0.z;
					            u_xlatb40 = -0.00999999978<u_xlat40;
					            u_xlat41 = (-u_xlat0.z) + -0.00999999978;
					            u_xlat41 = u_xlat41 / u_xlat3.z;
					            u_xlat40 = (u_xlatb40) ? u_xlat41 : _MaxRayTraceDistance;
					            u_xlat5.xyz = u_xlat3.xyz * vec3(u_xlat40) + u_xlat0.xyz;
					            u_xlat6.xyz = u_xlat0.yyy * _ProjectToPixelMatrix[1].xyw;
					            u_xlat6.xyz = _ProjectToPixelMatrix[0].xyw * u_xlat0.xxx + u_xlat6.xyz;
					            u_xlat6.xyz = _ProjectToPixelMatrix[2].xyw * u_xlat0.zzz + u_xlat6.xyz;
					            u_xlat6.xyz = u_xlat6.xyz + _ProjectToPixelMatrix[3].xyw;
					            u_xlat7.xyz = u_xlat5.yyy * _ProjectToPixelMatrix[1].xyw;
					            u_xlat7.xyz = _ProjectToPixelMatrix[0].xyw * u_xlat5.xxx + u_xlat7.xyz;
					            u_xlat7.xyz = _ProjectToPixelMatrix[2].xyw * u_xlat5.zzz + u_xlat7.xyz;
					            u_xlat7.xyz = u_xlat7.xyz + _ProjectToPixelMatrix[3].xyw;
					            u_xlat40 = float(1.0) / u_xlat6.z;
					            u_xlat41 = float(1.0) / u_xlat7.z;
					            u_xlat30.xy = vec2(u_xlat40) * u_xlat6.yx;
					            u_xlat32.xy = vec2(u_xlat41) * u_xlat7.xy;
					            u_xlat8.xyz = u_xlat0.xyz * vec3(u_xlat40);
					            u_xlat5.xyz = vec3(u_xlat41) * u_xlat5.xyz;
					            u_xlat33.xy = _ScreenSize.yx + vec2(-0.5, -0.5);
					            u_xlatb9.xy = lessThan(u_xlat33.xyxx, u_xlat32.yxyy).xy;
					            u_xlatb35.xy = lessThan(u_xlat32.yxyx, vec4(0.5, 0.5, 0.5, 0.5)).xy;
					            {
					                bvec2 hlslcc_orTemp = u_xlatb35;
					                hlslcc_orTemp.x = u_xlatb35.x || u_xlatb9.x;
					                hlslcc_orTemp.y = u_xlatb35.y || u_xlatb9.y;
					                u_xlatb35 = hlslcc_orTemp;
					            }
					            {
					                vec2 hlslcc_movcTemp = u_xlat33;
					                hlslcc_movcTemp.x = (u_xlatb9.x) ? (-u_xlat33.x) : float(-0.5);
					                hlslcc_movcTemp.y = (u_xlatb9.y) ? (-u_xlat33.y) : float(-0.5);
					                u_xlat33 = hlslcc_movcTemp;
					            }
					            u_xlat33.xy = u_xlat7.yx * vec2(u_xlat41) + u_xlat33.xy;
					            u_xlat7.xy = u_xlat7.yx * vec2(u_xlat41) + (-u_xlat30.xy);
					            u_xlat7.xy = u_xlat33.xy / u_xlat7.xy;
					            u_xlat42 = u_xlatb35.x ? u_xlat7.x : float(0.0);
					            u_xlat44 = max(u_xlat7.y, u_xlat42);
					            u_xlat42 = (u_xlatb35.y) ? u_xlat44 : u_xlat42;
					            u_xlat7.xy = u_xlat6.xy * vec2(u_xlat40) + (-u_xlat32.xy);
					            u_xlat32.xy = vec2(u_xlat42) * u_xlat7.xy + u_xlat32.xy;
					            u_xlat44 = u_xlat40 + (-u_xlat41);
					            u_xlat41 = u_xlat42 * u_xlat44 + u_xlat41;
					            u_xlat7.xyz = u_xlat0.xyz * vec3(u_xlat40) + (-u_xlat5.xyz);
					            u_xlat5.xyz = vec3(u_xlat42) * u_xlat7.xyz + u_xlat5.xyz;
					            u_xlat7.xy = u_xlat6.xy * vec2(u_xlat40) + (-u_xlat32.xy);
					            u_xlat42 = dot(u_xlat7.xy, u_xlat7.xy);
					            u_xlatb42 = u_xlat42<9.99999975e-05;
					            u_xlat7.xy = u_xlat6.xy * vec2(u_xlat40) + vec2(0.00999999978, 0.00999999978);
					            u_xlat7.xy = (bool(u_xlatb42)) ? u_xlat7.xy : u_xlat32.xy;
					            u_xlat7.zw = (-u_xlat6.xy) * vec2(u_xlat40) + u_xlat7.xy;
					            u_xlatb42 = abs(u_xlat7.z)<abs(u_xlat7.w);
					            u_xlat30.xy = (bool(u_xlatb42)) ? u_xlat30.xy : u_xlat30.yx;
					            u_xlat6.xyz = (bool(u_xlatb42)) ? u_xlat7.ywz : u_xlat7.xzw;
					            u_xlati44 = int((0.0<u_xlat6.y) ? 0xFFFFFFFFu : uint(0));
					            u_xlati45 = int((u_xlat6.y<0.0) ? 0xFFFFFFFFu : uint(0));
					            u_xlati44 = (-u_xlati44) + u_xlati45;
					            u_xlat7.x = float(u_xlati44);
					            u_xlat44 = u_xlat7.x / u_xlat6.y;
					            u_xlat7.y = u_xlat6.z * u_xlat44;
					            u_xlat5.xyz = (-u_xlat0.xyz) * vec3(u_xlat40) + u_xlat5.xyz;
					            u_xlat5.xyz = vec3(u_xlat44) * u_xlat5.xyz;
					            u_xlat0.x = (-u_xlat40) + u_xlat41;
					            u_xlat0.x = u_xlat44 * u_xlat0.x;
					            u_xlat13.x = trunc(_RayStepSize);
					            u_xlat5.xyw = u_xlat13.xxx * u_xlat5.xyz;
					            u_xlat41 = u_xlat13.x * u_xlat0.x;
					            u_xlat6.x = u_xlat6.x * u_xlat7.x;
					            u_xlat19 = (-_LayerThickness) + 100000.0;
					            u_xlatb19 = u_xlat0.z>=u_xlat19;
					            u_xlatb32 = 100000.0>=u_xlat0.z;
					            u_xlatb19 = u_xlatb32 && u_xlatb19;
					            u_xlat9 = u_xlat8.z;
					            u_xlat22 = u_xlat40;
					            u_xlat32.x = float(-1.0);
					            u_xlat32.y = float(-1.0);
					            u_xlat10.xy = u_xlat30.xy;
					            u_xlati33 = 0;
					            u_xlati46 = int(u_xlatb19);
					            u_xlat11.y = u_xlat0.z;
					            u_xlati47 = int(u_xlatb19);
					            while(true){
					                u_xlat35.x = u_xlat7.x * u_xlat10.x;
					                u_xlatb35.x = u_xlat6.x>=u_xlat35.x;
					                u_xlatb48 = u_xlati33<_MaxSteps;
					                u_xlatb35.x = u_xlatb48 && u_xlatb35.x;
					                u_xlati48 = ~(u_xlati47);
					                u_xlati35 = u_xlatb35.x ? u_xlati48 : int(0);
					                if(u_xlati35 == 0) {break;}
					                u_xlat35.x = u_xlat5.w * 0.5 + u_xlat9;
					                u_xlat48 = u_xlat41 * 0.5 + u_xlat22;
					                u_xlat11.x = u_xlat35.x / u_xlat48;
					                u_xlatb35.x = u_xlat11.x<u_xlat11.y;
					                u_xlat35.xy = (u_xlatb35.x) ? u_xlat11.xy : u_xlat11.yx;
					                u_xlat32.xy = (bool(u_xlatb42)) ? u_xlat10.yx : u_xlat10.xy;
					                u_xlat36.xy = u_xlat4.xy * u_xlat32.xy;
					                u_xlat12 = textureLod(_CameraDepthTexture, u_xlat36.xy, 0.0);
					                u_xlat36.x = _ZBufferParams.z * u_xlat12.x + _ZBufferParams.w;
					                u_xlat36.x = float(1.0) / u_xlat36.x;
					                u_xlati35 = int(((-u_xlat36.x)>=u_xlat35.x) ? 0xFFFFFFFFu : uint(0));
					                u_xlat36.x = (-u_xlat36.x) + (-_LayerThickness);
					                u_xlatb48 = u_xlat35.y>=u_xlat36.x;
					                u_xlati46 = u_xlatb48 ? u_xlati35 : int(0);
					                u_xlati47 = (u_xlatb39) ? u_xlati46 : u_xlati35;
					                u_xlat10.xy = u_xlat7.xy * u_xlat13.xx + u_xlat10.xy;
					                u_xlat9 = u_xlat5.z * u_xlat13.x + u_xlat9;
					                u_xlat22 = u_xlat0.x * u_xlat13.x + u_xlat22;
					                u_xlati33 = u_xlati33 + 1;
					                u_xlat11.y = u_xlat11.x;
					            }
					            u_xlat4.z = (-u_xlat5.z) * u_xlat13.x + u_xlat9;
					            u_xlat0.x = (-u_xlat0.x) * u_xlat13.x + u_xlat22;
					            u_xlat13.x = float(u_xlati33);
					            u_xlat4.xy = u_xlat5.xy * u_xlat13.xx + u_xlat8.xy;
					            u_xlat0.x = float(1.0) / u_xlat0.x;
					            u_xlat5.xy = u_xlat32.xy / _ScreenSize.xy;
					            u_xlat0.xzw = u_xlat4.xyz * u_xlat0.xxx + (-u_xlat1.xyz);
					            u_xlat5.z = dot(u_xlat0.xzw, u_xlat3.xyz);
					            if(u_xlati46 != 0) {
					                u_xlat0.x = u_xlat13.x + u_xlat13.x;
					                u_xlat13.x = float(_MaxSteps);
					                u_xlat0.x = u_xlat0.x / u_xlat13.x;
					                u_xlat0.x = u_xlat0.x + -1.0;
					                u_xlat0.x = max(u_xlat0.x, 0.0);
					                u_xlat0.x = (-u_xlat0.x) + 1.0;
					                u_xlat0.x = u_xlat0.x * u_xlat0.x;
					                u_xlat13.x = (-u_xlat5.z) + _MaxRayTraceDistance;
					                u_xlat13.x = u_xlat13.x / unused_0_18.y;
					                u_xlat13.x = clamp(u_xlat13.x, 0.0, 1.0);
					                u_xlat0.x = u_xlat13.x * u_xlat0.x;
					                u_xlat13.x = dot(u_xlat3.xyz, u_xlat2.xyz);
					                u_xlat13.x = log2(abs(u_xlat13.x));
					                u_xlat13.x = u_xlat13.x * _FresnelFadePower;
					                u_xlat13.x = exp2(u_xlat13.x);
					                u_xlat26 = (-_FresnelFade) + 1.0;
					                u_xlat39 = (-u_xlat13.x) + 1.0;
					                u_xlat13.x = u_xlat26 * u_xlat39 + u_xlat13.x;
					                u_xlat13.x = max(u_xlat13.x, 0.0);
					                u_xlat0.x = u_xlat13.x * u_xlat0.x;
					                u_xlatb13 = 0<_TreatBackfaceHitAsMiss;
					                if(u_xlatb13){
					                    u_xlat1 = textureLod(_CameraGBufferTexture2, u_xlat5.xy, 0.0);
					                    u_xlat13.xyz = u_xlat1.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					                    u_xlat1.xyz = u_xlat3.yyy * _CameraToWorldMatrix[1].xyz;
					                    u_xlat1.xyz = _CameraToWorldMatrix[0].xyz * u_xlat3.xxx + u_xlat1.xyz;
					                    u_xlat1.xyz = _CameraToWorldMatrix[2].xyz * u_xlat3.zzz + u_xlat1.xyz;
					                    u_xlat13.x = dot(u_xlat13.xyz, u_xlat1.xyz);
					                    u_xlatb13 = 0.0<u_xlat13.x;
					                    u_xlat0.x = (u_xlatb13) ? 0.0 : u_xlat0.x;
					                }
					            } else {
					                u_xlat0.x = 0.0;
					            }
					            u_xlat13.xy = (-u_xlat5.xy) + vec2(1.0, 1.0);
					            u_xlat13.x = min(u_xlat13.y, u_xlat13.x);
					            u_xlat26 = min(u_xlat5.x, u_xlat5.x);
					            u_xlat13.x = min(u_xlat26, u_xlat13.x);
					            u_xlat26 = _ScreenEdgeFading * 0.100000001 + 0.00100000005;
					            u_xlat13.x = u_xlat13.x / u_xlat26;
					            u_xlat13.x = clamp(u_xlat13.x, 0.0, 1.0);
					            u_xlat13.x = log2(u_xlat13.x);
					            u_xlat13.x = u_xlat13.x * 0.200000003;
					            u_xlat13.x = exp2(u_xlat13.x);
					            u_xlat13.x = u_xlat13.x * u_xlat13.x;
					            SV_Target0.w = u_xlat0.x * u_xlat13.x;
					            SV_Target0.xyz = u_xlat5.xyz;
					        } else {
					            SV_Target0 = vec4(0.0, 0.0, 0.0, 0.0);
					        }
					    } else {
					        SV_Target0 = vec4(0.0, 0.0, 0.0, 0.0);
					    }
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 115347
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
						vec4 unused_0_0[4];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[30];
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
					in  vec2 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					 vec4 phase0_Output0_1;
					out vec2 vs_TEXCOORD1;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					float u_xlat2;
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
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat2 = (-in_TEXCOORD0.y) + 1.0;
					    phase0_Output0_1.w = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    phase0_Output0_1.xyz = in_TEXCOORD0.xyx;
					vs_TEXCOORD0 = phase0_Output0_1.xy;
					vs_TEXCOORD1 = phase0_Output0_1.zw;
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
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2;
						vec4 _ProjInfo;
						vec4 unused_0_4[4];
						mat4x4 _CameraToWorldMatrix;
						vec4 unused_0_6[9];
						int _AdditiveReflection;
						vec4 unused_0_8;
						float _SSRMultiplier;
						vec4 unused_0_10[8];
					};
					layout(std140) uniform UnityPerCamera {
						vec4 unused_1_0[7];
						vec4 _ZBufferParams;
						vec4 unused_1_2;
					};
					uniform  sampler2D _CameraDepthTexture;
					uniform  sampler2D _MainTex;
					uniform  sampler2D _CameraGBufferTexture1;
					uniform  sampler2D _FinalReflectionTexture;
					uniform  sampler2D _CameraGBufferTexture0;
					uniform  sampler2D _CameraGBufferTexture2;
					uniform  sampler2D _CameraReflectionsTexture;
					in  vec2 vs_TEXCOORD0;
					in  vec2 vs_TEXCOORD1;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec3 u_xlat3;
					vec3 u_xlat4;
					float u_xlat6;
					float u_xlat9;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD1.xy * _MainTex_TexelSize.zw;
					    u_xlat0.xy = u_xlat0.xy * _ProjInfo.xy + _ProjInfo.zw;
					    u_xlat1 = texture(_CameraDepthTexture, vs_TEXCOORD1.xy);
					    u_xlat6 = _ZBufferParams.z * u_xlat1.x + _ZBufferParams.w;
					    u_xlat6 = float(1.0) / u_xlat6;
					    u_xlat1.z = (-u_xlat6);
					    u_xlat1.xy = u_xlat0.xy * u_xlat1.zz;
					    u_xlat0.x = dot(u_xlat1.xyz, u_xlat1.xyz);
					    u_xlat0.x = inversesqrt(u_xlat0.x);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat1.xyz = u_xlat0.yyy * _CameraToWorldMatrix[1].xyz;
					    u_xlat0.xyw = _CameraToWorldMatrix[0].xyz * u_xlat0.xxx + u_xlat1.xyz;
					    u_xlat0.xyz = _CameraToWorldMatrix[2].xyz * u_xlat0.zzz + u_xlat0.xyw;
					    u_xlat1 = texture(_CameraGBufferTexture2, vs_TEXCOORD1.xy);
					    u_xlat1.xyz = u_xlat1.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat0.x = dot(u_xlat1.xyz, (-u_xlat0.xyz));
					    u_xlat0.x = -abs(u_xlat0.x) + 1.0;
					    u_xlat3.x = u_xlat0.x * u_xlat0.x;
					    u_xlat3.x = u_xlat3.x * u_xlat3.x;
					    u_xlat0.x = u_xlat0.x * u_xlat3.x;
					    u_xlat1 = texture(_CameraGBufferTexture1, vs_TEXCOORD1.xy);
					    u_xlat3.x = max(u_xlat1.y, u_xlat1.x);
					    u_xlat3.x = max(u_xlat1.z, u_xlat3.x);
					    u_xlat3.x = (-u_xlat3.x) + 1.0;
					    u_xlat3.x = (-u_xlat3.x) + 1.0;
					    u_xlat3.x = u_xlat3.x + u_xlat1.w;
					    u_xlat3.x = clamp(u_xlat3.x, 0.0, 1.0);
					    u_xlat3.xyz = (-u_xlat1.xyz) + u_xlat3.xxx;
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat3.xyz + u_xlat1.xyz;
					    u_xlat9 = (-u_xlat1.w) + 1.0;
					    u_xlat1.x = u_xlat9 * u_xlat9;
					    u_xlat1.x = max(u_xlat1.x, 0.00200000009);
					    u_xlat1.x = u_xlat1.x * 0.280000001;
					    u_xlat9 = (-u_xlat1.x) * u_xlat9 + 1.0;
					    u_xlat1 = texture(_FinalReflectionTexture, vs_TEXCOORD1.xy).wxyz;
					    u_xlat4.xyz = vec3(u_xlat9) * u_xlat1.yzw;
					    u_xlat1.x = u_xlat1.x;
					    u_xlat1.x = clamp(u_xlat1.x, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat4.xyz;
					    u_xlat4.xyz = u_xlat0.xyz * vec3(_SSRMultiplier);
					    u_xlat4.xyz = u_xlat1.xxx * u_xlat4.xyz;
					    u_xlat2 = texture(_CameraReflectionsTexture, vs_TEXCOORD1.xy);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(_SSRMultiplier) + (-u_xlat2.xyz);
					    u_xlat0.xyz = u_xlat1.xxx * u_xlat0.xyz + u_xlat2.xyz;
					    u_xlat0.xyz = (int(_AdditiveReflection) != 0) ? u_xlat4.xyz : u_xlat0.xyz;
					    u_xlat1 = texture(_CameraGBufferTexture0, vs_TEXCOORD1.xy);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.www;
					    u_xlat2.w = 0.0;
					    u_xlat1 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat2 = (-u_xlat2) + u_xlat1;
					    u_xlat2 = max(u_xlat2, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlat1 = (int(_AdditiveReflection) != 0) ? u_xlat1 : u_xlat2;
					    u_xlat0.w = 0.0;
					    SV_Target0 = u_xlat0 + u_xlat1;
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 194299
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
						vec4 unused_0_0[4];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[30];
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
					in  vec2 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					 vec4 phase0_Output0_1;
					out vec2 vs_TEXCOORD1;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					float u_xlat2;
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
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat2 = (-in_TEXCOORD0.y) + 1.0;
					    phase0_Output0_1.w = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    phase0_Output0_1.xyz = in_TEXCOORD0.xyx;
					vs_TEXCOORD0 = phase0_Output0_1.xy;
					vs_TEXCOORD1 = phase0_Output0_1.zw;
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
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[22];
						int _HighlightSuppression;
						vec4 unused_0_4[5];
						vec4 _Axis;
						vec4 unused_0_6;
					};
					uniform  sampler2D _NormalAndRoughnessTexture;
					uniform  sampler2D _MainTex;
					in  vec2 vs_TEXCOORD1;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					vec4 u_xlat4;
					vec4 u_xlat5;
					vec4 u_xlat6;
					vec4 u_xlat7;
					float u_xlat8;
					vec4 u_xlat9;
					vec4 u_xlat10;
					vec4 u_xlat11;
					vec4 u_xlat12;
					vec4 u_xlat13;
					vec3 u_xlat14;
					vec3 u_xlat16;
					vec3 u_xlat22;
					bool u_xlatb28;
					float u_xlat29;
					float u_xlat30;
					float u_xlat36;
					float u_xlat42;
					float u_xlat43;
					float u_xlat44;
					float u_xlat50;
					void main()
					{
					    u_xlat0 = texture(_NormalAndRoughnessTexture, vs_TEXCOORD1.xy);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xy = _MainTex_TexelSize.xy * _Axis.xy;
					    u_xlat2 = u_xlat1.xyxy * vec4(-8.0, -8.0, -6.0, -6.0) + vs_TEXCOORD1.xyxy;
					    u_xlat3 = texture(_MainTex, u_xlat2.xy);
					    u_xlat42 = u_xlat3.w * 0.0524999984;
					    u_xlat4 = texture(_NormalAndRoughnessTexture, u_xlat2.xy);
					    u_xlat4.xyz = u_xlat4.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat29 = dot(u_xlat0.xyz, u_xlat4.xyz);
					    u_xlat29 = clamp(u_xlat29, 0.0, 1.0);
					    u_xlat43 = u_xlat42 * u_xlat29;
					    u_xlat4.xyz = u_xlat3.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat4.xyz = u_xlat3.xyz / u_xlat4.xyz;
					    u_xlat3.xyz = (_HighlightSuppression != 0) ? u_xlat4.xyz : u_xlat3.xyz;
					    u_xlat4 = texture(_MainTex, u_xlat2.zw);
					    u_xlat2.x = u_xlat4.w * 0.075000003;
					    u_xlat5 = texture(_NormalAndRoughnessTexture, u_xlat2.zw);
					    u_xlat16.xyz = u_xlat5.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat16.x = dot(u_xlat0.xyz, u_xlat16.xyz);
					    u_xlat16.x = clamp(u_xlat16.x, 0.0, 1.0);
					    u_xlat2.x = u_xlat16.x * u_xlat2.x;
					    u_xlat42 = u_xlat42 * u_xlat29 + u_xlat2.x;
					    u_xlat16.xyz = u_xlat4.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat16.xyz = u_xlat4.xyz / u_xlat16.xyz;
					    u_xlat4.xyz = (_HighlightSuppression != 0) ? u_xlat16.xyz : u_xlat4.xyz;
					    u_xlat5 = u_xlat1.xyxy * vec4(-4.0, -4.0, -2.0, -2.0) + vs_TEXCOORD1.xyxy;
					    u_xlat6 = texture(_MainTex, u_xlat5.xy);
					    u_xlat29 = u_xlat6.w * 0.109999999;
					    u_xlat7 = texture(_NormalAndRoughnessTexture, u_xlat5.xy);
					    u_xlat16.xyz = u_xlat7.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat16.x = dot(u_xlat0.xyz, u_xlat16.xyz);
					    u_xlat16.x = clamp(u_xlat16.x, 0.0, 1.0);
					    u_xlat30 = u_xlat29 * u_xlat16.x;
					    u_xlat42 = u_xlat29 * u_xlat16.x + u_xlat42;
					    u_xlat7.xyz = u_xlat6.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat7.xyz = u_xlat6.xyz / u_xlat7.xyz;
					    u_xlat6.xyz = (_HighlightSuppression != 0) ? u_xlat7.xyz : u_xlat6.xyz;
					    u_xlat7 = texture(_MainTex, u_xlat5.zw);
					    u_xlat29 = u_xlat7.w * 0.150000006;
					    u_xlat5 = texture(_NormalAndRoughnessTexture, u_xlat5.zw);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat16.x = dot(u_xlat0.xyz, u_xlat5.xyz);
					    u_xlat16.x = clamp(u_xlat16.x, 0.0, 1.0);
					    u_xlat44 = u_xlat29 * u_xlat16.x;
					    u_xlat42 = u_xlat29 * u_xlat16.x + u_xlat42;
					    u_xlat5.xyz = u_xlat7.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat5.xyz = u_xlat7.xyz / u_xlat5.xyz;
					    u_xlat7.xyz = (_HighlightSuppression != 0) ? u_xlat5.xyz : u_xlat7.xyz;
					    u_xlat5 = texture(_MainTex, vs_TEXCOORD1.xy);
					    u_xlat29 = u_xlat5.w * 0.224999994;
					    u_xlat16.x = dot(u_xlat0.xyz, u_xlat0.xyz);
					    u_xlat16.x = min(u_xlat16.x, 1.0);
					    u_xlat8 = u_xlat29 * u_xlat16.x;
					    u_xlat42 = u_xlat29 * u_xlat16.x + u_xlat42;
					    u_xlat22.xyz = u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat22.xyz = u_xlat5.xyz / u_xlat22.xyz;
					    u_xlat5.xyz = (_HighlightSuppression != 0) ? u_xlat22.xyz : u_xlat5.xyz;
					    u_xlat22.xy = u_xlat1.xy * vec2(2.0, 2.0) + vs_TEXCOORD1.xy;
					    u_xlat9 = texture(_MainTex, u_xlat22.xy);
					    u_xlat29 = u_xlat9.w * 0.150000006;
					    u_xlat10 = texture(_NormalAndRoughnessTexture, u_xlat22.xy);
					    u_xlat22.xyz = u_xlat10.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat16.x = dot(u_xlat0.xyz, u_xlat22.xyz);
					    u_xlat16.x = clamp(u_xlat16.x, 0.0, 1.0);
					    u_xlat22.x = u_xlat29 * u_xlat16.x;
					    u_xlat42 = u_xlat29 * u_xlat16.x + u_xlat42;
					    u_xlat10.xyz = u_xlat9.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat10.xyz = u_xlat9.xyz / u_xlat10.xyz;
					    u_xlat9.xyz = (_HighlightSuppression != 0) ? u_xlat10.xyz : u_xlat9.xyz;
					    u_xlat10 = u_xlat1.xyxy * vec4(4.0, 4.0, 6.0, 6.0) + vs_TEXCOORD1.xyxy;
					    u_xlat11 = texture(_MainTex, u_xlat10.xy);
					    u_xlat29 = u_xlat11.w * 0.109999999;
					    u_xlat12 = texture(_NormalAndRoughnessTexture, u_xlat10.xy);
					    u_xlat12.xyz = u_xlat12.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat16.x = dot(u_xlat0.xyz, u_xlat12.xyz);
					    u_xlat16.x = clamp(u_xlat16.x, 0.0, 1.0);
					    u_xlat36 = u_xlat29 * u_xlat16.x;
					    u_xlat42 = u_xlat29 * u_xlat16.x + u_xlat42;
					    u_xlat12.xyz = u_xlat11.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat12.xyz = u_xlat11.xyz / u_xlat12.xyz;
					    u_xlat11.xyz = (_HighlightSuppression != 0) ? u_xlat12.xyz : u_xlat11.xyz;
					    u_xlat12 = texture(_MainTex, u_xlat10.zw);
					    u_xlat29 = u_xlat12.w * 0.075000003;
					    u_xlat10 = texture(_NormalAndRoughnessTexture, u_xlat10.zw);
					    u_xlat10.xyz = u_xlat10.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat16.x = dot(u_xlat0.xyz, u_xlat10.xyz);
					    u_xlat16.x = clamp(u_xlat16.x, 0.0, 1.0);
					    u_xlat50 = u_xlat29 * u_xlat16.x;
					    u_xlat42 = u_xlat29 * u_xlat16.x + u_xlat42;
					    u_xlat10.xyz = u_xlat12.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat10.xyz = u_xlat12.xyz / u_xlat10.xyz;
					    u_xlat12.xyz = (_HighlightSuppression != 0) ? u_xlat10.xyz : u_xlat12.xyz;
					    u_xlat1.xy = u_xlat1.xy * vec2(8.0, 8.0) + vs_TEXCOORD1.xy;
					    u_xlat10 = texture(_MainTex, u_xlat1.xy);
					    u_xlat29 = u_xlat10.w * 0.0524999984;
					    u_xlat13 = texture(_NormalAndRoughnessTexture, u_xlat1.xy);
					    u_xlat13.xyz = u_xlat13.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat0.x = dot(u_xlat0.xyz, u_xlat13.xyz);
					    u_xlat0.x = clamp(u_xlat0.x, 0.0, 1.0);
					    u_xlat14.x = u_xlat0.x * u_xlat29;
					    u_xlat0.x = u_xlat29 * u_xlat0.x + u_xlat42;
					    u_xlat1.xyz = u_xlat10.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat1.xyz = u_xlat10.xyz / u_xlat1.xyz;
					    u_xlat10.xyz = (_HighlightSuppression != 0) ? u_xlat1.xyz : u_xlat10.xyz;
					    u_xlatb28 = 0.00999999978<u_xlat0.x;
					    if(u_xlatb28){
					        u_xlat13 = u_xlat2.xxxx * u_xlat4;
					        u_xlat1 = u_xlat3 * vec4(u_xlat43) + u_xlat13;
					        u_xlat1 = u_xlat6 * vec4(u_xlat30) + u_xlat1;
					        u_xlat1 = u_xlat7 * vec4(u_xlat44) + u_xlat1;
					        u_xlat1 = u_xlat5 * vec4(u_xlat8) + u_xlat1;
					        u_xlat1 = u_xlat9 * u_xlat22.xxxx + u_xlat1;
					        u_xlat1 = u_xlat11 * vec4(u_xlat36) + u_xlat1;
					        u_xlat1 = u_xlat12 * vec4(u_xlat50) + u_xlat1;
					        u_xlat1 = u_xlat10 * u_xlat14.xxxx + u_xlat1;
					        u_xlat0.x = float(1.0) / u_xlat0.x;
					        u_xlat14.x = max(u_xlat0.x, 2.0);
					        u_xlat14.x = sqrt(u_xlat14.x);
					        u_xlat14.x = u_xlat14.x * u_xlat1.w;
					        SV_Target0.w = min(u_xlat14.x, 1.0);
					        u_xlat14.xyz = u_xlat0.xxx * u_xlat1.xyz;
					        u_xlat1.xyz = (-u_xlat1.xyz) * u_xlat0.xxx + vec3(1.0, 1.0, 1.0);
					        u_xlat1.xyz = u_xlat14.xyz / u_xlat1.xyz;
					        SV_Target0.xyz = (_HighlightSuppression != 0) ? u_xlat1.xyz : u_xlat14.xyz;
					        return;
					    } else {
					        u_xlat0.xyz = u_xlat3.xyz + u_xlat4.xyz;
					        u_xlat0.xyz = u_xlat6.xyz + u_xlat0.xyz;
					        u_xlat0.xyz = u_xlat7.xyz + u_xlat0.xyz;
					        u_xlat0.xyz = u_xlat5.xyz + u_xlat0.xyz;
					        u_xlat0.xyz = u_xlat9.xyz + u_xlat0.xyz;
					        u_xlat0.xyz = u_xlat11.xyz + u_xlat0.xyz;
					        u_xlat0.xyz = u_xlat12.xyz + u_xlat0.xyz;
					        u_xlat0.xyz = u_xlat10.xyz + u_xlat0.xyz;
					        u_xlat1.xyz = u_xlat0.xyz * vec3(0.111111112, 0.111111112, 0.111111112);
					        u_xlat0.xyz = (-u_xlat0.xyz) * vec3(0.111111112, 0.111111112, 0.111111112) + vec3(1.0, 1.0, 1.0);
					        u_xlat0.xyz = u_xlat1.xyz / u_xlat0.xyz;
					        SV_Target0.xyz = (_HighlightSuppression != 0) ? u_xlat0.xyz : u_xlat1.xyz;
					        SV_Target0.w = 0.0;
					        return;
					    }
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 253458
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
						vec4 unused_0_0[4];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[30];
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
					in  vec2 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					 vec4 phase0_Output0_1;
					out vec2 vs_TEXCOORD1;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					float u_xlat2;
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
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat2 = (-in_TEXCOORD0.y) + 1.0;
					    phase0_Output0_1.w = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    phase0_Output0_1.xyz = in_TEXCOORD0.xyx;
					vs_TEXCOORD0 = phase0_Output0_1.xy;
					vs_TEXCOORD1 = phase0_Output0_1.zw;
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
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2;
						vec4 _ProjInfo;
						mat4x4 _WorldToCameraMatrix;
						vec4 unused_0_5[8];
						vec2 _ReflectionBufferSize;
						vec4 unused_0_7[3];
						int _HalfResolution;
						vec4 unused_0_9;
						float _ScreenEdgeFading;
						int _BilateralUpsampling;
						vec4 unused_0_12;
						float _PixelsPerMeterAtOneMeter;
						vec4 unused_0_14[7];
					};
					layout(std140) uniform UnityPerCamera {
						vec4 unused_1_0[7];
						vec4 _ZBufferParams;
						vec4 unused_1_2;
					};
					uniform  sampler2D _CameraGBufferTexture1;
					uniform  sampler2D _HitPointTexture;
					uniform  sampler2D _CameraDepthTexture;
					uniform  sampler2D _CameraGBufferTexture2;
					uniform  sampler2D _ReflectionTexture0;
					uniform  sampler2D _ReflectionTexture1;
					uniform  sampler2D _ReflectionTexture2;
					uniform  sampler2D _ReflectionTexture3;
					uniform  sampler2D _ReflectionTexture4;
					uniform  sampler2D _NormalAndRoughnessTexture;
					in  vec2 vs_TEXCOORD1;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					bool u_xlatb1;
					vec4 u_xlat2;
					bool u_xlatb2;
					vec4 u_xlat3;
					bool u_xlatb3;
					vec4 u_xlat4;
					vec4 u_xlat5;
					vec4 u_xlat6;
					vec4 u_xlat7;
					vec4 u_xlat8;
					vec4 u_xlat9;
					vec4 u_xlat10;
					vec4 u_xlat11;
					vec4 u_xlat12;
					vec3 u_xlat13;
					vec3 u_xlat14;
					bool u_xlatb14;
					vec3 u_xlat15;
					vec2 u_xlat16;
					vec2 u_xlat26;
					int u_xlati26;
					bool u_xlatb26;
					vec2 u_xlat27;
					vec2 u_xlat28;
					vec2 u_xlat29;
					float u_xlat39;
					int u_xlati39;
					float u_xlat40;
					float u_xlat41;
					void main()
					{
					    u_xlat0 = texture(_CameraGBufferTexture1, vs_TEXCOORD1.xy);
					    u_xlat0.x = (-u_xlat0.w) + 1.0;
					    u_xlat1 = texture(_HitPointTexture, vs_TEXCOORD1.xy);
					    u_xlat2 = texture(_CameraDepthTexture, vs_TEXCOORD1.xy);
					    u_xlat13.x = _ZBufferParams.z * u_xlat2.x + _ZBufferParams.w;
					    u_xlat13.x = float(1.0) / u_xlat13.x;
					    u_xlat2.z = (-u_xlat13.x);
					    u_xlat13.xy = vs_TEXCOORD1.xy * _MainTex_TexelSize.zw;
					    u_xlat13.xy = u_xlat13.xy * _ProjInfo.xy + _ProjInfo.zw;
					    u_xlat2.xy = u_xlat2.zz * u_xlat13.xy;
					    u_xlat3 = texture(_CameraGBufferTexture2, vs_TEXCOORD1.xy);
					    u_xlat13.xyz = u_xlat3.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyw = u_xlat13.yyy * _WorldToCameraMatrix[1].xyz;
					    u_xlat1.xyw = _WorldToCameraMatrix[0].xyz * u_xlat13.xxx + u_xlat1.xyw;
					    u_xlat13.xyz = _WorldToCameraMatrix[2].xyz * u_xlat13.zzz + u_xlat1.xyw;
					    u_xlat1.x = dot(u_xlat2.xyz, u_xlat2.xyz);
					    u_xlat1.x = inversesqrt(u_xlat1.x);
					    u_xlat1.xyw = u_xlat1.xxx * u_xlat2.xyz;
					    u_xlat2.x = dot(u_xlat13.xyz, (-u_xlat1.xyw));
					    u_xlat2.x = u_xlat2.x + u_xlat2.x;
					    u_xlat13.xyz = u_xlat13.xyz * u_xlat2.xxx + u_xlat1.xyw;
					    u_xlat13.x = dot(u_xlat13.xyz, u_xlat13.xyz);
					    u_xlat13.x = inversesqrt(u_xlat13.x);
					    u_xlat13.x = u_xlat13.x * u_xlat13.z;
					    u_xlat13.x = u_xlat13.x * u_xlat1.z + u_xlat2.z;
					    u_xlat26.x = log2(u_xlat0.x);
					    u_xlat26.x = u_xlat26.x * 1.33333337;
					    u_xlat26.x = exp2(u_xlat26.x);
					    u_xlat26.x = u_xlat1.z * u_xlat26.x;
					    u_xlat26.x = u_xlat26.x * _PixelsPerMeterAtOneMeter;
					    u_xlat13.x = u_xlat26.x / u_xlat13.x;
					    u_xlatb26 = _HalfResolution==1;
					    u_xlat39 = u_xlat13.x * 0.5;
					    u_xlat13.x = (u_xlatb26) ? u_xlat39 : u_xlat13.x;
					    u_xlat13.x = u_xlat13.x + 15.0;
					    u_xlat13.x = u_xlat13.x * 0.0625;
					    u_xlat13.x = log2(u_xlat13.x);
					    u_xlat13.x = min(u_xlat13.x, 4.0);
					    u_xlat13.x = max(u_xlat13.x, 0.0);
					    u_xlati26 = int(u_xlat13.x);
					    u_xlati39 = u_xlati26 + 1;
					    u_xlati39 = min(u_xlati39, 4);
					    u_xlat1.x = trunc(u_xlat13.x);
					    u_xlat13.x = u_xlat13.x + (-u_xlat1.x);
					    u_xlatb1 = _BilateralUpsampling==1;
					    if(u_xlatb1){
					        u_xlat1.x = float((-u_xlati26));
					        u_xlat1.x = exp2(u_xlat1.x);
					        u_xlat1 = u_xlat1.xxxx * vec4(_ReflectionBufferSize.x, _ReflectionBufferSize.y, _ReflectionBufferSize.x, _ReflectionBufferSize.y);
					        u_xlat1 = floor(u_xlat1);
					        u_xlat2 = vs_TEXCOORD1.xyxy * u_xlat1.zwzw + vec4(-0.5, -0.5, -0.5, -0.5);
					        u_xlat2 = floor(u_xlat2);
					        u_xlat2 = u_xlat2 + vec4(1.5, 0.5, 0.5, 1.5);
					        u_xlat3 = vec4(1.0, 1.0, 1.0, 1.0) / u_xlat1;
					        u_xlat3 = u_xlat2 * u_xlat3;
					        if(u_xlati26 == 0) {
					            u_xlat4 = textureLod(_ReflectionTexture0, u_xlat3.zy, 0.0);
					            u_xlat5 = textureLod(_ReflectionTexture0, u_xlat3.xy, 0.0);
					            u_xlat6 = textureLod(_ReflectionTexture0, u_xlat3.zw, 0.0);
					            u_xlat7 = textureLod(_ReflectionTexture0, u_xlat3.xw, 0.0);
					        } else {
					            u_xlatb1 = u_xlati26==1;
					            if(u_xlatb1){
					                u_xlat4 = textureLod(_ReflectionTexture1, u_xlat3.zy, 0.0);
					            } else {
					                u_xlatb14 = u_xlati26==2;
					                if(u_xlatb14){
					                    u_xlat4 = textureLod(_ReflectionTexture2, u_xlat3.zy, 0.0);
					                } else {
					                    u_xlatb14 = u_xlati26==3;
					                    if(u_xlatb14){
					                        u_xlat4 = textureLod(_ReflectionTexture3, u_xlat3.zy, 0.0);
					                    } else {
					                        u_xlat4 = textureLod(_ReflectionTexture4, u_xlat3.zy, 0.0);
					                    }
					                }
					            }
					            if(u_xlatb1){
					                u_xlat5 = textureLod(_ReflectionTexture1, u_xlat3.xy, 0.0);
					            } else {
					                u_xlatb14 = u_xlati26==2;
					                if(u_xlatb14){
					                    u_xlat5 = textureLod(_ReflectionTexture2, u_xlat3.xy, 0.0);
					                } else {
					                    u_xlatb14 = u_xlati26==3;
					                    if(u_xlatb14){
					                        u_xlat5 = textureLod(_ReflectionTexture3, u_xlat3.xy, 0.0);
					                    } else {
					                        u_xlat5 = textureLod(_ReflectionTexture4, u_xlat3.xy, 0.0);
					                    }
					                }
					            }
					            if(u_xlatb1){
					                u_xlat6 = textureLod(_ReflectionTexture1, u_xlat3.zw, 0.0);
					            } else {
					                u_xlatb14 = u_xlati26==2;
					                if(u_xlatb14){
					                    u_xlat6 = textureLod(_ReflectionTexture2, u_xlat3.zw, 0.0);
					                } else {
					                    u_xlatb14 = u_xlati26==3;
					                    if(u_xlatb14){
					                        u_xlat6 = textureLod(_ReflectionTexture3, u_xlat3.zw, 0.0);
					                    } else {
					                        u_xlat6 = textureLod(_ReflectionTexture4, u_xlat3.zw, 0.0);
					                    }
					                }
					            }
					            if(u_xlatb1){
					                u_xlat7 = textureLod(_ReflectionTexture1, u_xlat3.xw, 0.0);
					            } else {
					                u_xlatb1 = u_xlati26==2;
					                if(u_xlatb1){
					                    u_xlat7 = textureLod(_ReflectionTexture2, u_xlat3.xw, 0.0);
					                } else {
					                    u_xlatb1 = u_xlati26==3;
					                    if(u_xlatb1){
					                        u_xlat7 = textureLod(_ReflectionTexture3, u_xlat3.xw, 0.0);
					                    } else {
					                        u_xlat7 = textureLod(_ReflectionTexture4, u_xlat3.xw, 0.0);
					                    }
					                }
					            }
					        }
					        u_xlat1.xy = vs_TEXCOORD1.xy * u_xlat1.zw + (-u_xlat2.zy);
					        u_xlat27.xy = (-u_xlat1.yx) + vec2(1.0, 1.0);
					        u_xlat2.x = u_xlat27.x * u_xlat27.y;
					        u_xlat27.xy = u_xlat27.xy * u_xlat1.xy;
					        u_xlat1.x = u_xlat1.y * u_xlat1.x;
					        u_xlat8 = vec4(1.0, 1.0, 1.0, 1.0) / vec4(_ReflectionBufferSize.x, _ReflectionBufferSize.y, _ReflectionBufferSize.x, _ReflectionBufferSize.y);
					        u_xlat9 = u_xlat3.zyxw * vec4(_ReflectionBufferSize.x, _ReflectionBufferSize.y, _ReflectionBufferSize.x, _ReflectionBufferSize.y) + vec4(-0.5, -0.5, -0.5, -0.5);
					        u_xlat9 = floor(u_xlat9);
					        u_xlat9 = u_xlat9 + vec4(0.5, 0.5, 0.5, 0.5);
					        u_xlat9 = u_xlat8 * u_xlat9;
					        u_xlat3 = u_xlat3 * vec4(_ReflectionBufferSize.x, _ReflectionBufferSize.y, _ReflectionBufferSize.x, _ReflectionBufferSize.y) + vec4(-0.5, -0.5, -0.5, -0.5);
					        u_xlat3 = floor(u_xlat3);
					        u_xlat3 = u_xlat3 + vec4(0.5, 0.5, 0.5, 0.5);
					        u_xlat3 = u_xlat8 * u_xlat3;
					        u_xlat10 = textureLod(_NormalAndRoughnessTexture, vs_TEXCOORD1.xy, 0.0);
					        u_xlat15.xyz = u_xlat10.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					        u_xlat11 = textureLod(_NormalAndRoughnessTexture, u_xlat9.xy, 0.0);
					        u_xlat12 = textureLod(_NormalAndRoughnessTexture, u_xlat3.xy, 0.0);
					        u_xlat3 = textureLod(_NormalAndRoughnessTexture, u_xlat3.zw, 0.0);
					        u_xlat9 = textureLod(_NormalAndRoughnessTexture, u_xlat9.zw, 0.0);
					        u_xlat10.xyz = u_xlat11.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					        u_xlat11.xyz = u_xlat12.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					        u_xlat3.xyz = u_xlat3.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					        u_xlat9.xyz = u_xlat9.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					        u_xlat14.x = dot(u_xlat15.xyz, u_xlat10.xyz);
					        u_xlat14.x = clamp(u_xlat14.x, 0.0, 1.0);
					        u_xlat14.x = u_xlat14.x * u_xlat2.x;
					        u_xlat2.x = dot(u_xlat15.xyz, u_xlat11.xyz);
					        u_xlat2.x = clamp(u_xlat2.x, 0.0, 1.0);
					        u_xlat27.x = u_xlat27.x * u_xlat2.x;
					        u_xlat2.x = dot(u_xlat15.xyz, u_xlat3.xyz);
					        u_xlat2.x = clamp(u_xlat2.x, 0.0, 1.0);
					        u_xlat40 = u_xlat27.y * u_xlat2.x;
					        u_xlat2.x = dot(u_xlat15.xyz, u_xlat9.xyz);
					        u_xlat2.x = clamp(u_xlat2.x, 0.0, 1.0);
					        u_xlat1.x = u_xlat1.x * u_xlat2.x;
					        u_xlat2.x = u_xlat10.w + (-u_xlat11.w);
					        u_xlat2.x = sqrt(abs(u_xlat2.x));
					        u_xlat2.x = sqrt(u_xlat2.x);
					        u_xlat2.x = (-u_xlat2.x) + 1.0;
					        u_xlat1.y = u_xlat14.x * u_xlat2.x;
					        u_xlat2.x = u_xlat10.w + (-u_xlat12.w);
					        u_xlat2.x = sqrt(abs(u_xlat2.x));
					        u_xlat2.x = sqrt(u_xlat2.x);
					        u_xlat2.x = (-u_xlat2.x) + 1.0;
					        u_xlat1.z = u_xlat27.x * u_xlat2.x;
					        u_xlat2.x = (-u_xlat3.w) + u_xlat10.w;
					        u_xlat2.x = sqrt(abs(u_xlat2.x));
					        u_xlat2.x = sqrt(u_xlat2.x);
					        u_xlat2.x = (-u_xlat2.x) + 1.0;
					        u_xlat1.w = u_xlat40 * u_xlat2.x;
					        u_xlat2.x = (-u_xlat9.w) + u_xlat10.w;
					        u_xlat2.x = sqrt(abs(u_xlat2.x));
					        u_xlat2.x = sqrt(u_xlat2.x);
					        u_xlat2.x = (-u_xlat2.x) + 1.0;
					        u_xlat1.x = u_xlat1.x * u_xlat2.x;
					        u_xlat1 = max(u_xlat1, vec4(0.00100000005, 0.00100000005, 0.00100000005, 0.00100000005));
					        u_xlat2.x = u_xlat1.z + u_xlat1.y;
					        u_xlat2.x = u_xlat1.w + u_xlat2.x;
					        u_xlat2.x = u_xlat1.x + u_xlat2.x;
					        u_xlat2.x = float(1.0) / u_xlat2.x;
					        u_xlat3 = u_xlat1.zzzz * u_xlat5;
					        u_xlat3 = u_xlat4 * u_xlat1.yyyy + u_xlat3;
					        u_xlat3 = u_xlat6 * u_xlat1.wwww + u_xlat3;
					        u_xlat1 = u_xlat7 * u_xlat1.xxxx + u_xlat3;
					        u_xlat1 = u_xlat2.xxxx * u_xlat1;
					        u_xlat2.x = float((-u_xlati39));
					        u_xlat2.x = exp2(u_xlat2.x);
					        u_xlat3 = u_xlat2.xxxx * vec4(_ReflectionBufferSize.x, _ReflectionBufferSize.y, _ReflectionBufferSize.x, _ReflectionBufferSize.y);
					        u_xlat3 = floor(u_xlat3);
					        u_xlat4 = vs_TEXCOORD1.xyxy * u_xlat3.zwzw + vec4(-0.5, -0.5, -0.5, -0.5);
					        u_xlat4 = floor(u_xlat4);
					        u_xlat4 = u_xlat4 + vec4(1.5, 0.5, 0.5, 1.5);
					        u_xlat5 = vec4(1.0, 1.0, 1.0, 1.0) / u_xlat3;
					        u_xlat5 = u_xlat4 * u_xlat5;
					        u_xlatb2 = u_xlati39==1;
					        if(u_xlatb2){
					            u_xlat6 = textureLod(_ReflectionTexture1, u_xlat5.zy, 0.0);
					            u_xlat7 = textureLod(_ReflectionTexture1, u_xlat5.xy, 0.0);
					            u_xlat9 = textureLod(_ReflectionTexture1, u_xlat5.zw, 0.0);
					            u_xlat11 = textureLod(_ReflectionTexture1, u_xlat5.xw, 0.0);
					        } else {
					            u_xlatb2 = u_xlati39==2;
					            if(u_xlatb2){
					                u_xlat6 = textureLod(_ReflectionTexture2, u_xlat5.zy, 0.0);
					            } else {
					                u_xlatb3 = u_xlati39==3;
					                if(u_xlatb3){
					                    u_xlat6 = textureLod(_ReflectionTexture3, u_xlat5.zy, 0.0);
					                } else {
					                    u_xlat6 = textureLod(_ReflectionTexture4, u_xlat5.zy, 0.0);
					                }
					            }
					            if(u_xlatb2){
					                u_xlat7 = textureLod(_ReflectionTexture2, u_xlat5.xy, 0.0);
					            } else {
					                u_xlatb3 = u_xlati39==3;
					                if(u_xlatb3){
					                    u_xlat7 = textureLod(_ReflectionTexture3, u_xlat5.xy, 0.0);
					                } else {
					                    u_xlat7 = textureLod(_ReflectionTexture4, u_xlat5.xy, 0.0);
					                }
					            }
					            if(u_xlatb2){
					                u_xlat9 = textureLod(_ReflectionTexture2, u_xlat5.zw, 0.0);
					            } else {
					                u_xlatb3 = u_xlati39==3;
					                if(u_xlatb3){
					                    u_xlat9 = textureLod(_ReflectionTexture3, u_xlat5.zw, 0.0);
					                } else {
					                    u_xlat9 = textureLod(_ReflectionTexture4, u_xlat5.zw, 0.0);
					                }
					            }
					            if(u_xlatb2){
					                u_xlat11 = textureLod(_ReflectionTexture2, u_xlat5.xw, 0.0);
					            } else {
					                u_xlatb2 = u_xlati39==3;
					                if(u_xlatb2){
					                    u_xlat11 = textureLod(_ReflectionTexture3, u_xlat5.xw, 0.0);
					                } else {
					                    u_xlat11 = textureLod(_ReflectionTexture4, u_xlat5.xw, 0.0);
					                }
					            }
					        }
					        u_xlat3.xy = vs_TEXCOORD1.xy * u_xlat3.zw + (-u_xlat4.zy);
					        u_xlat29.xy = (-u_xlat3.yx) + vec2(1.0, 1.0);
					        u_xlat2.x = u_xlat29.x * u_xlat29.y;
					        u_xlat29.xy = u_xlat29.xy * u_xlat3.xy;
					        u_xlat3.x = u_xlat3.y * u_xlat3.x;
					        u_xlat4 = u_xlat5.zyxw * vec4(_ReflectionBufferSize.x, _ReflectionBufferSize.y, _ReflectionBufferSize.x, _ReflectionBufferSize.y) + vec4(-0.5, -0.5, -0.5, -0.5);
					        u_xlat4 = floor(u_xlat4);
					        u_xlat4 = u_xlat4 + vec4(0.5, 0.5, 0.5, 0.5);
					        u_xlat4 = u_xlat8 * u_xlat4;
					        u_xlat5 = u_xlat5 * vec4(_ReflectionBufferSize.x, _ReflectionBufferSize.y, _ReflectionBufferSize.x, _ReflectionBufferSize.y) + vec4(-0.5, -0.5, -0.5, -0.5);
					        u_xlat5 = floor(u_xlat5);
					        u_xlat5 = u_xlat5 + vec4(0.5, 0.5, 0.5, 0.5);
					        u_xlat5 = u_xlat8 * u_xlat5;
					        u_xlat8 = textureLod(_NormalAndRoughnessTexture, u_xlat4.xy, 0.0);
					        u_xlat12 = textureLod(_NormalAndRoughnessTexture, u_xlat5.xy, 0.0);
					        u_xlat5 = textureLod(_NormalAndRoughnessTexture, u_xlat5.zw, 0.0);
					        u_xlat4 = textureLod(_NormalAndRoughnessTexture, u_xlat4.zw, 0.0);
					        u_xlat8.xyz = u_xlat8.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					        u_xlat10.xyz = u_xlat12.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					        u_xlat5.xyz = u_xlat5.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					        u_xlat4.xyz = u_xlat4.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					        u_xlat16.x = dot(u_xlat15.xyz, u_xlat8.xyz);
					        u_xlat16.x = clamp(u_xlat16.x, 0.0, 1.0);
					        u_xlat2.x = u_xlat2.x * u_xlat16.x;
					        u_xlat16.x = dot(u_xlat15.xyz, u_xlat10.xyz);
					        u_xlat16.x = clamp(u_xlat16.x, 0.0, 1.0);
					        u_xlat16.x = u_xlat16.x * u_xlat29.x;
					        u_xlat29.x = dot(u_xlat15.xyz, u_xlat5.xyz);
					        u_xlat29.x = clamp(u_xlat29.x, 0.0, 1.0);
					        u_xlat16.y = u_xlat29.x * u_xlat29.y;
					        u_xlat15.x = dot(u_xlat15.xyz, u_xlat4.xyz);
					        u_xlat15.x = clamp(u_xlat15.x, 0.0, 1.0);
					        u_xlat15.x = u_xlat15.x * u_xlat3.x;
					        u_xlat28.x = (-u_xlat8.w) + u_xlat10.w;
					        u_xlat28.x = sqrt(abs(u_xlat28.x));
					        u_xlat28.x = sqrt(u_xlat28.x);
					        u_xlat28.x = (-u_xlat28.x) + 1.0;
					        u_xlat2.x = u_xlat28.x * u_xlat2.x;
					        u_xlat28.x = u_xlat10.w + (-u_xlat12.w);
					        u_xlat28.x = sqrt(abs(u_xlat28.x));
					        u_xlat28.x = sqrt(u_xlat28.x);
					        u_xlat28.x = (-u_xlat28.x) + 1.0;
					        u_xlat41 = (-u_xlat5.w) + u_xlat10.w;
					        u_xlat41 = sqrt(abs(u_xlat41));
					        u_xlat41 = sqrt(u_xlat41);
					        u_xlat28.y = (-u_xlat41) + 1.0;
					        u_xlat2.zw = u_xlat28.xy * u_xlat16.xy;
					        u_xlat3.x = (-u_xlat4.w) + u_xlat10.w;
					        u_xlat3.x = sqrt(abs(u_xlat3.x));
					        u_xlat3.x = sqrt(u_xlat3.x);
					        u_xlat3.x = (-u_xlat3.x) + 1.0;
					        u_xlat2.y = u_xlat15.x * u_xlat3.x;
					        u_xlat2 = max(u_xlat2, vec4(0.00100000005, 0.00100000005, 0.00100000005, 0.00100000005));
					        u_xlat3.x = u_xlat2.z + u_xlat2.x;
					        u_xlat3.x = u_xlat2.w + u_xlat3.x;
					        u_xlat3.x = u_xlat2.y + u_xlat3.x;
					        u_xlat3.x = float(1.0) / u_xlat3.x;
					        u_xlat4 = u_xlat2.zzzz * u_xlat7;
					        u_xlat4 = u_xlat6 * u_xlat2.xxxx + u_xlat4;
					        u_xlat4 = u_xlat9 * u_xlat2.wwww + u_xlat4;
					        u_xlat2 = u_xlat11 * u_xlat2.yyyy + u_xlat4;
					        u_xlat2 = u_xlat2 * u_xlat3.xxxx + (-u_xlat1);
					        u_xlat1 = u_xlat13.xxxx * u_xlat2.wxyz + u_xlat1.wxyz;
					        SV_Target0.xyz = u_xlat1.yzw;
					    } else {
					        if(u_xlati26 == 0) {
					            u_xlat2 = textureLod(_ReflectionTexture0, vs_TEXCOORD1.xy, 0.0);
					        } else {
					            u_xlatb14 = u_xlati26==1;
					            if(u_xlatb14){
					                u_xlat2 = textureLod(_ReflectionTexture1, vs_TEXCOORD1.xy, 0.0);
					            } else {
					                u_xlatb14 = u_xlati26==2;
					                if(u_xlatb14){
					                    u_xlat2 = textureLod(_ReflectionTexture2, vs_TEXCOORD1.xy, 0.0);
					                } else {
					                    u_xlatb26 = u_xlati26==3;
					                    if(u_xlatb26){
					                        u_xlat2 = textureLod(_ReflectionTexture3, vs_TEXCOORD1.xy, 0.0);
					                    } else {
					                        u_xlat2 = textureLod(_ReflectionTexture4, vs_TEXCOORD1.xy, 0.0);
					                    }
					                }
					            }
					        }
					        u_xlatb26 = u_xlati39==1;
					        if(u_xlatb26){
					            u_xlat3 = textureLod(_ReflectionTexture1, vs_TEXCOORD1.xy, 0.0);
					        } else {
					            u_xlatb26 = u_xlati39==2;
					            if(u_xlatb26){
					                u_xlat3 = textureLod(_ReflectionTexture2, vs_TEXCOORD1.xy, 0.0);
					            } else {
					                u_xlatb26 = u_xlati39==3;
					                if(u_xlatb26){
					                    u_xlat3 = textureLod(_ReflectionTexture3, vs_TEXCOORD1.xy, 0.0);
					                } else {
					                    u_xlat3 = textureLod(_ReflectionTexture4, vs_TEXCOORD1.xy, 0.0);
					                }
					            }
					        }
					        u_xlat14.xyz = (-u_xlat2.xyz) + u_xlat3.xyz;
					        SV_Target0.xyz = u_xlat13.xxx * u_xlat14.xyz + u_xlat2.xyz;
					        u_xlat1.x = min(u_xlat2.w, u_xlat3.w);
					    }
					    u_xlat13.x = min(u_xlat1.x, 1.0);
					    u_xlat26.xy = (-vs_TEXCOORD1.xy) + vec2(1.0, 1.0);
					    u_xlat26.x = min(u_xlat26.y, u_xlat26.x);
					    u_xlat26.x = min(u_xlat26.x, vs_TEXCOORD1.x);
					    u_xlat39 = unused_0_9.w * 0.100000001 + 0.00100000005;
					    u_xlat26.x = u_xlat26.x / u_xlat39;
					    u_xlat26.x = clamp(u_xlat26.x, 0.0, 1.0);
					    u_xlat26.x = log2(u_xlat26.x);
					    u_xlat26.x = u_xlat26.x * 0.200000003;
					    u_xlat26.x = exp2(u_xlat26.x);
					    u_xlat13.x = u_xlat26.x * u_xlat13.x;
					    u_xlat0.x = u_xlat0.x * 0.300000012;
					    u_xlat0.x = clamp(u_xlat0.x, 0.0, 1.0);
					    u_xlat0.x = (-u_xlat0.x) + 1.0;
					    SV_Target0.w = u_xlat0.x * u_xlat13.x;
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 326708
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
						vec4 unused_0_0[4];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[30];
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
					in  vec2 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					 vec4 phase0_Output0_1;
					out vec2 vs_TEXCOORD1;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					float u_xlat2;
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
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat2 = (-in_TEXCOORD0.y) + 1.0;
					    phase0_Output0_1.w = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    phase0_Output0_1.xyz = in_TEXCOORD0.xyx;
					vs_TEXCOORD0 = phase0_Output0_1.xy;
					vs_TEXCOORD1 = phase0_Output0_1.zw;
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
						vec4 unused_0_0[19];
						vec2 _ReflectionBufferSize;
						vec4 unused_0_2[14];
						int _LastMip;
					};
					uniform  sampler2D _MainTex;
					in  vec2 vs_TEXCOORD1;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					vec2 u_xlat8;
					void main()
					{
					    u_xlat0.x = float((-_LastMip));
					    u_xlat0.x = exp2(u_xlat0.x);
					    u_xlat0.xy = u_xlat0.xx * vec2(_ReflectionBufferSize.x, _ReflectionBufferSize.y);
					    u_xlat0.xy = floor(u_xlat0.xy);
					    u_xlat8.xy = vs_TEXCOORD1.xy * u_xlat0.xy + vec2(-0.5, -0.5);
					    u_xlat0.xy = vec2(1.0, 1.0) / u_xlat0.xy;
					    u_xlat8.xy = floor(u_xlat8.xy);
					    u_xlat8.xy = u_xlat8.xy + vec2(0.5, 0.5);
					    u_xlat1.xy = u_xlat0.xy * u_xlat8.xy;
					    u_xlat1.zw = u_xlat8.xy * u_xlat0.xy + u_xlat0.xy;
					    u_xlat0 = texture(_MainTex, u_xlat1.xw);
					    u_xlat2 = texture(_MainTex, u_xlat1.zy);
					    u_xlat3 = texture(_MainTex, u_xlat1.xy);
					    u_xlat1 = texture(_MainTex, u_xlat1.zw);
					    u_xlat1 = min(u_xlat1, u_xlat3);
					    u_xlat0 = min(u_xlat0, u_xlat2);
					    SV_Target0 = min(u_xlat0, u_xlat1);
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 358014
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
						vec4 unused_0_0[4];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[30];
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
					in  vec2 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					 vec4 phase0_Output0_1;
					out vec2 vs_TEXCOORD1;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					float u_xlat2;
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
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat2 = (-in_TEXCOORD0.y) + 1.0;
					    phase0_Output0_1.w = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    phase0_Output0_1.xyz = in_TEXCOORD0.xyx;
					vs_TEXCOORD0 = phase0_Output0_1.xy;
					vs_TEXCOORD1 = phase0_Output0_1.zw;
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
					
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					uniform  sampler2D _HitPointTexture;
					uniform  sampler2D _MainTex;
					uniform  sampler2D _CameraReflectionsTexture;
					in  vec2 vs_TEXCOORD1;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					ivec3 u_xlati1;
					bvec3 u_xlatb1;
					vec4 u_xlat2;
					bool u_xlatb9;
					void main()
					{
					    u_xlat0 = texture(_CameraReflectionsTexture, vs_TEXCOORD1.xy);
					    u_xlat1 = texture(_HitPointTexture, vs_TEXCOORD1.xy);
					    u_xlatb9 = 0.0<u_xlat1.w;
					    u_xlat2 = texture(_MainTex, u_xlat1.xy);
					    SV_Target0.w = u_xlat1.w;
					    u_xlat0.xyz = (bool(u_xlatb9)) ? u_xlat2.xyz : u_xlat0.xyz;
					    u_xlati1.xyz = ivec3(floatBitsToUint(u_xlat0.xyz) & uvec3(2139095040u, 2139095040u, 2139095040u));
					    u_xlatb1.xyz = notEqual(u_xlati1.xyzx, ivec4(int(0x7F800000u), int(0x7F800000u), int(0x7F800000u), 0)).xyz;
					    u_xlatb9 = u_xlatb1.y && u_xlatb1.x;
					    u_xlatb9 = u_xlatb1.z && u_xlatb9;
					    SV_Target0.xyz = bool(u_xlatb9) ? u_xlat0.xyz : vec3(0.0, 0.0, 0.0);
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 407151
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
						vec4 unused_0_0[4];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[30];
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
					in  vec2 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					 vec4 phase0_Output0_1;
					out vec2 vs_TEXCOORD1;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					float u_xlat2;
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
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat2 = (-in_TEXCOORD0.y) + 1.0;
					    phase0_Output0_1.w = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    phase0_Output0_1.xyz = in_TEXCOORD0.xyx;
					vs_TEXCOORD0 = phase0_Output0_1.xy;
					vs_TEXCOORD1 = phase0_Output0_1.zw;
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
					
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					uniform  sampler2D _CameraGBufferTexture2;
					uniform  sampler2D _CameraGBufferTexture1;
					in  vec2 vs_TEXCOORD1;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					void main()
					{
					    u_xlat0 = texture(_CameraGBufferTexture2, vs_TEXCOORD1.xy);
					    SV_Target0.xyz = u_xlat0.xyz;
					    u_xlat0 = texture(_CameraGBufferTexture1, vs_TEXCOORD1.xy);
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
			GpuProgramID 479679
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
						vec4 unused_0_0[4];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[30];
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
					in  vec2 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					 vec4 phase0_Output0_1;
					out vec2 vs_TEXCOORD1;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					float u_xlat2;
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
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat2 = (-in_TEXCOORD0.y) + 1.0;
					    phase0_Output0_1.w = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    phase0_Output0_1.xyz = in_TEXCOORD0.xyx;
					vs_TEXCOORD0 = phase0_Output0_1.xy;
					vs_TEXCOORD1 = phase0_Output0_1.zw;
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
					layout(std140) uniform UnityPerCamera {
						vec4 unused_0_0[7];
						vec4 _ZBufferParams;
						vec4 unused_0_2;
					};
					uniform  sampler2D _CameraDepthTexture;
					in  vec2 vs_TEXCOORD1;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					void main()
					{
					    u_xlat0 = texture(_CameraDepthTexture, vs_TEXCOORD1.xy);
					    u_xlat0.x = _ZBufferParams.z * u_xlat0.x + _ZBufferParams.w;
					    u_xlat0.x = float(1.0) / u_xlat0.x;
					    SV_Target0.x = (-u_xlat0.x);
					    SV_Target0.yzw = vec3(0.0, 0.0, 0.0);
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 545449
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
						vec4 unused_0_0[4];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[30];
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
					in  vec2 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					 vec4 phase0_Output0_1;
					out vec2 vs_TEXCOORD1;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					float u_xlat2;
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
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat2 = (-in_TEXCOORD0.y) + 1.0;
					    phase0_Output0_1.w = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    phase0_Output0_1.xyz = in_TEXCOORD0.xyx;
					vs_TEXCOORD0 = phase0_Output0_1.xy;
					vs_TEXCOORD1 = phase0_Output0_1.zw;
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
					vec2 ImmCB_0_0_0[12];
					layout(std140) uniform PGlobals {
						vec4 unused_0_0[4];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[18];
						float _ReflectionBlur;
						vec4 unused_0_4[3];
						int _HighlightSuppression;
						vec4 unused_0_6[7];
					};
					uniform  sampler2D _MainTex;
					in  vec2 vs_TEXCOORD1;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec3 u_xlat3;
					int u_xlati4;
					vec2 u_xlat8;
					bool u_xlatb8;
					void main()
					{
						ImmCB_0_0_0[0] = vec2(-0.326211989, -0.405809999);
						ImmCB_0_0_0[1] = vec2(-0.840143979, -0.0735799968);
						ImmCB_0_0_0[2] = vec2(-0.69591397, 0.457136989);
						ImmCB_0_0_0[3] = vec2(-0.203345001, 0.620715976);
						ImmCB_0_0_0[4] = vec2(0.962339997, -0.194983006);
						ImmCB_0_0_0[5] = vec2(0.473434001, -0.480026007);
						ImmCB_0_0_0[6] = vec2(0.519456029, 0.767022014);
						ImmCB_0_0_0[7] = vec2(0.185461, -0.893123984);
						ImmCB_0_0_0[8] = vec2(0.507430971, 0.0644249991);
						ImmCB_0_0_0[9] = vec2(0.896420002, 0.412458003);
						ImmCB_0_0_0[10] = vec2(-0.321940005, -0.932614982);
						ImmCB_0_0_0[11] = vec2(-0.791558981, -0.597710013);
					    u_xlat0.x = _MainTex_TexelSize.x * _ReflectionBlur;
					    u_xlat1.x = float(0.0);
					    u_xlat1.y = float(0.0);
					    u_xlat1.z = float(0.0);
					    u_xlat1.w = float(0.0);
					    for(int u_xlati_loop_1 = 0 ; u_xlati_loop_1<12 ; u_xlati_loop_1++)
					    {
					        u_xlat8.xy = ImmCB_0_0_0[u_xlati_loop_1].xy * u_xlat0.xx + vs_TEXCOORD1.xy;
					        u_xlat2 = texture(_MainTex, u_xlat8.xy);
					        u_xlat3.xyz = u_xlat2.xyz + vec3(1.0, 1.0, 1.0);
					        u_xlat3.xyz = u_xlat2.xyz / u_xlat3.xyz;
					        u_xlat2.xyz = (_HighlightSuppression != 0) ? u_xlat3.xyz : u_xlat2.xyz;
					        u_xlat1 = u_xlat1 + u_xlat2;
					    }
					    u_xlat0 = u_xlat1 * vec4(0.0833333358, 0.0833333358, 0.0833333358, 0.0833333358);
					    u_xlat1.xyz = (-u_xlat1.xyz) * vec3(0.0833333358, 0.0833333358, 0.0833333358) + vec3(1.0, 1.0, 1.0);
					    u_xlat1.xyz = u_xlat0.xyz / u_xlat1.xyz;
					    SV_Target0.xyz = (_HighlightSuppression != 0) ? u_xlat1.xyz : u_xlat0.xyz;
					    SV_Target0.w = u_xlat0.w;
					    return;
					}"
				}
			}
		}
	}
	Fallback "Diffuse"
}